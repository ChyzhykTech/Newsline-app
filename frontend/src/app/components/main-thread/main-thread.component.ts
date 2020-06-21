import { Component, OnInit, OnDestroy } from "@angular/core";
import { Post } from "../../models/post/post";
import { User } from "../../models/user";
import { Subject } from "rxjs";
import { MatSlideToggleChange } from "@angular/material/slide-toggle";
import { AuthenticationService } from "../../services/auth.service";
import { PostService } from "../../services/post.service";
import { AuthDialogService } from "../../services/auth-dialog.service";
import { DialogType } from "../../models/common/auth-dialog-type";
import { EventService } from "../../services/event.service";
import { ImgurService } from "../../services/imgur.service";
import { NewPost } from "../../models/post/new-post";
import { switchMap, takeUntil } from "rxjs/operators";
import { HubConnection } from "@aspnet/signalr";
import { SnackBarService } from "../../services/snack-bar.service";
import { HubUser } from 'src/app/models/hub-user';
import { LikeSnackbar } from 'src/app/models/snackbar/like-snackbar';
import { PostHubService } from 'src/app/services/post-hub.service';
import { ActivatedRoute } from '@angular/router';
import { RouterExtService } from 'src/app/services/router-ext.service';

@Component({
  selector: "app-main-thread",
  templateUrl: "./main-thread.component.html",
  styleUrls: ["./main-thread.component.sass"],
})
export class MainThreadComponent implements OnInit, OnDestroy {
  public asSinglePost: boolean = false;
  public posts: Post[] = [];
  public cachedPosts: Post[] = [];
  public authUsersInHub: HubUser[] = [];
  public hideOwnPosts = false;
  public isOnlyMine = false;
  public isOnlyLiked = false;
  public isEditMode = false;

  public currentUser: User;
  public imageUrl: string;
  public imageFile: File;
  public post = {} as NewPost;
  public editablePost = {} as Post;
  public showPostContainer = false;
  public loading = false;
  public loadingPosts = false;

  private unsubscribe$ = new Subject<void>();

  public constructor(
    private route: ActivatedRoute,
    private routerExt: RouterExtService,
    private snackBarService: SnackBarService,
    private authService: AuthenticationService,
    private postService: PostService,
    private imgurService: ImgurService,
    private authDialogService: AuthDialogService,
    private eventService: EventService,
    private postHubService: PostHubService
  ) { }

  public ngOnDestroy() {
    this.unsubscribe$.next();
    this.unsubscribe$.complete();
    this.postHubService.stopHub();
  }

  public ngOnInit() {
    this.registerHubHandlers();
    this.getPosts();
    this.getUser();   
    this.eventService.userChangedEvent$
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe((user) => {
        this.currentUser = user;
        this.post.authorId = this.currentUser ? this.currentUser.id : undefined;
      });    
  }

  public onNotifyUserByPost(post: Post) {
    let connection: HubConnection = this.postHubService.getConnection();
    let hubUser = this.authUsersInHub.find((user) => user.userId === post.author.id);
    if (hubUser !== undefined) {
      connection.invoke("SendLike", hubUser.connectionId, post.id)
        .catch((err) => this.snackBarService.showErrorMessage(err));
    }       
  }

  public onDeletePost(postId: number) {
    this.loadingPosts = true;
    this.postService
      .deletePost(postId)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe(
        (resp) => {
          this.loadingPosts = false;
          if (resp.ok) {
            this.posts = this.cachedPosts = this.cachedPosts.filter(
              (post) => post.id !== postId
            );

            if (this.isOnlyMine || this.isOnlyLiked) {
              this.posts = this.showPostsByFilterParams();
            }
          }
        },
        (err) => {
          this.snackBarService.showErrorMessage("Server responsed with error");
          this.loadingPosts = false;
        }
      );
  }

  public onEditPost(postId: number) {
    let post = this.cachedPosts.find((post) => post.id === postId);
    if (post !== null) {
      this.showPostContainer = true;
      this.isEditMode = true;
      this.imageUrl = post.previewImage;
      this.post.body = post.body;
      Object.assign(this.editablePost, post);
    }
  }

  public getPosts() {
    this.loadingPosts = true;
    this.postService
      .getPosts()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe(
        (resp) => {
          this.loadingPosts = false;
          this.posts = this.cachedPosts = resp.body;
          this.setSelectedPostFromQueryParams();
        },
        (error) => (this.loadingPosts = false)
      );
  }

  public sendPost() {
    if (this.isEditMode) {
      this.loading = true;
      this.editPost();
      return;
    }
    const postSubscription = !this.imageFile
      ? this.postService.createPost(this.post)
      : this.imgurService.uploadToImgur(this.imageFile, "title").pipe(
          switchMap((imageData) => {
            this.post.previewImage = imageData.body.data.link;
            return this.postService.createPost(this.post);
          })
        );

    this.loading = true;

    postSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
      (respPost) => {
        this.addNewPost(respPost.body);
        this.removeImage();
        this.post.body = undefined;
        this.post.previewImage = undefined;
        this.loading = false;
      },
      (error) => this.snackBarService.showErrorMessage(error)
    );
  }

  public loadImage(target: any) {
    this.imageFile = target.files[0];

    if (!this.imageFile) {
      target.value = "";
      return;
    }

    if (this.imageFile.size / 1000000 > 5) {
      target.value = "";
      this.snackBarService.showErrorMessage(`Image can't be heavier than ~5MB`);
      return;
    }

    const reader = new FileReader();
    reader.addEventListener(
      "load",
      () => (this.imageUrl = reader.result as string)
    );
    reader.readAsDataURL(this.imageFile);
  }

  public removeImage() {
    this.imageUrl = undefined;
    this.imageFile = undefined;
    this.editablePost.previewImage = null;
  }

  public hideSliderChanged(event: MatSlideToggleChange) {
    if (event.checked) {

      if (this.isOnlyMine) {
        this.isOnlyMine = !this.isOnlyMine;
      }

      this.hideOwnPosts = true;

    } else {
      this.hideOwnPosts = false;
    }
    this.posts = this.showPostsByFilterParams();
  }

  public sliderChanged(event: MatSlideToggleChange) {
    if (event.checked) {

      if(this.hideOwnPosts) {
        this.hideOwnPosts = !this.hideOwnPosts;
      }

      this.isOnlyMine = true;

    } else {
      this.isOnlyMine = false;
    }
    this.posts = this.showPostsByFilterParams();
  }

  public likeSliderChanged(event: MatSlideToggleChange) {
    if (event.checked) {
      this.isOnlyLiked= true;      
    } else {
      this.isOnlyLiked = false;
    }
    this.posts = this.showPostsByFilterParams();
  }

  public toggleNewPostContainer() {
    this.showPostContainer = !this.showPostContainer;
  }

  public openAuthDialog() {
    this.authDialogService.openAuthDialog(DialogType.SignIn);
  }

  public registerHubHandlers() {
    let connection: HubConnection = this.postHubService.getConnection();
    connection.on("NewPost", (newPost: Post) => {
      if (newPost) {
        this.addNewPost(newPost);
      }
    });

    connection.on("Notify", (userId, connectionId) => {
      if(userId === null) return;
      let hubUser: HubUser = {
        userId: userId,
        connectionId: connectionId
      };
      this.authUsersInHub.push(hubUser);
    });

    connection.on("UserDisconnected", (connectionId) => {
      let user = this.authUsersInHub.find((user) => user.connectionId === connectionId);
      let index = this.authUsersInHub.indexOf(user);
      if (index !== -1) this.authUsersInHub.splice(index, 1);
    });

    connection.on("LikePost", (fromUser: User, postId: number) => {
      let post = this.cachedPosts.find((post) => post.id === postId);
      if(post !== undefined) {
        let likeSnackbar: LikeSnackbar = {fromUser, post};
        this.snackBarService.showLikeMessage(likeSnackbar);
      }       
    });
  }

  public addNewPost(newPost: Post) {
    if (!this.cachedPosts.some((x) => x.id === newPost.id)) {
      this.cachedPosts = this.sortPostArray(this.cachedPosts.concat(newPost));
      if (
        !this.isOnlyMine ||
        (this.isOnlyMine && newPost.author.id === this.currentUser.id)
      ) {
        this.posts = this.sortPostArray(this.posts.concat(newPost));
      }
    }
  }

  private setSelectedPostFromQueryParams() {
    this.route.queryParams
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe(params => {
         let postId = params["postId"];
         if (postId !== null && postId !== undefined) {
            this.posts = this.cachedPosts.filter(post => post.id == postId);
            this.asSinglePost = true;
          } else {
            this.asSinglePost = false;
          }
          console.log(this.asSinglePost)
      });
  }

  private updatePost(updatedPost: Post) {
    let oldPost = this.cachedPosts.find(post => post.id === updatedPost.id);
    let index = this.cachedPosts.indexOf(oldPost);
    this.cachedPosts.splice(index, 1, updatedPost);
    if(this.isOnlyMine || this.isOnlyLiked) {
      this.posts = this.showPostsByFilterParams();
    } else {
      this.posts = this.cachedPosts;
    }
  }

  private showPostsByFilterParams() {
    this.resetVisiblePosts();
    let filteringArr = [];
    let isOnlyLiked = [];

    if(!this.isOnlyMine && !this.isOnlyLiked && !this.hideOwnPosts) return this.cachedPosts;

    if(this.hideOwnPosts) {
      filteringArr = this.cachedPosts.filter(
        (x) => x.author.id !== this.currentUser.id);
    } else if (this.isOnlyMine) {
      filteringArr = this.cachedPosts.filter(
        (x) => x.author.id === this.currentUser.id);
    }

    if(this.isOnlyLiked) {
      isOnlyLiked = this.cachedPosts.filter(
        (x) => {
          let containsLikes = [];
          x.reactions.forEach((r) => {
            containsLikes.push(r.user.id === this.currentUser.id);
          });
          return containsLikes.includes(true);
        });
    }

    let filterRes = [...filteringArr, ...isOnlyLiked];

    return filterRes.length > 0 ? this.sortPostArray(filterRes) : [];
  }

  private resetVisiblePosts() {
    this.posts = [];
  }

  private getUser() {
    this.authService
      .getUser()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe((user) => (this.currentUser = user));
  }

  //after edit set to False
  private editPost() {
    this.editablePost.body = this.post.body;
    const postSubscription = !this.imageFile
      ? this.postService.updatePost(this.editablePost)
      : this.imgurService.uploadToImgur(this.imageFile, "title").pipe(
          switchMap((imageData) => {
            this.editablePost.previewImage = imageData.body.data.link;
            return this.postService.updatePost(this.editablePost);
          })
        );

    postSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
      (resp) => {
        if(resp.ok) {
          this.updatePost(this.editablePost);
          this.removeImage();
          this.post.body = undefined;
          this.post.previewImage = undefined;
          this.editablePost = {} as Post;
          this.loading = false;
          this.isEditMode = false;
          this.showPostContainer = false;
          this.snackBarService.showUsualMessage("Post was updated");
        } else {
          this.snackBarService.showErrorMessage("Update error");
        }
      },
      (error) => this.snackBarService.showErrorMessage("Update error")
    );
  }

  private sortPostArray(array: Post[]): Post[] {
    return array.sort(
      (a, b) => +new Date(b.createdAt) - +new Date(a.createdAt)
    );
  }
}
