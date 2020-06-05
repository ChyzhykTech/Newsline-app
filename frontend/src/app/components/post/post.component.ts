import { Component, Input, OnDestroy, Output, OnInit, EventEmitter, ViewChildren, ViewChild } from '@angular/core';
import { Post } from '../../models/post/post';
import { AuthenticationService } from '../../services/auth.service';
import { AuthDialogService } from '../../services/auth-dialog.service';
import { empty, Observable, Subject } from 'rxjs';
import { DialogType } from '../../models/common/auth-dialog-type';
import { LikeService } from '../../services/like.service';
import { NewComment } from '../../models/comment/new-comment';
import { CommentService } from '../../services/comment.service';
import { User } from '../../models/user';
import { Comment } from '../../models/comment/comment';
import { catchError, switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { EditComment } from 'src/app/models/comment/edit-comment';
import { NgbTooltip } from '@ng-bootstrap/ng-bootstrap';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnDestroy, OnInit {

    @Input() public post: Post;
    @Input() public currentUser: User;
    @Output() public deleteClick = new EventEmitter<number>();
    @Output() public editClick = new EventEmitter<number>();
    @Output() private likedPost = new EventEmitter<Post>();

    public likePhotos = [];
    public showComments = false;
    public newComment = {} as NewComment;
    public editableComment = {} as EditComment;
    public isEditMode = false;
    private unsubscribe$ = new Subject<void>();

    @ViewChild('tt', {static: false}) tooltip: NgbTooltip;

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private commentService: CommentService,
        private snackBarService: SnackBarService
    ) { }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public ngOnInit() {
        this.setLikePhotos();
    }

    public deletePost(postId: number) {
        this.deleteClick.emit(postId);
    }

    public editPost(postId: number) {
        this.editClick.emit(postId);
    }

    public onDeleteComment(commentId: number) {
        this.commentService.deleteComment(commentId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((resp) => {
                if (!resp.ok) {this.snackBarService.showErrorMessage("Comment delete error")}
                this.post.comments = this.post.comments.filter(
                    (comment) => comment.id !== commentId);
                this.snackBarService.showUsualMessage("Comment was deleted")
            });
    }

    public onEditComment(commentId: number) {
        let comment = this.post.comments
            .find((comment) => comment.id === commentId);
        if (comment !== null) {
          this.isEditMode = true;
          this.newComment.body = comment.body;
          this.editableComment.commentId = commentId;
        }
    }
   
    public toggleComments() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((user) => {
                    if (user) {
                        this.currentUser = user;
                        this.showComments = !this.showComments;
                    }
                });
            return;
        }

        this.showComments = !this.showComments;
    }

    public likePost() {
        let countReactions = this.post.reactions.length;
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.likePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => {
                    this.setPostData(post);
                    if (countReactions < post.reactions.length) {
                        this.likedPost.emit(post);
                    }    
                });

            return;
        }

        this.likeService
            .likePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => {
                this.setPostData(post);
                if (countReactions < post.reactions.length) {
                    this.likedPost.emit(post);
                }              
            });
    }

    public dislikePost() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.dislikePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => (this.setPostData(post)));

            return;
        }

        this.likeService
            .dislikePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => (this.setPostData(post)));
    }

    public sendComment() {
        if (this.isEditMode) {
            this.editComment();
            return;
        }

        this.newComment.authorId = this.currentUser.id;
        this.newComment.postId = this.post.id;

        this.commentService
            .createComment(this.newComment)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    if (resp) {
                        this.post.comments = this.sortCommentArray(this.post.comments.concat(resp.body));
                        this.newComment.body = undefined;
                    }
                },
                (error) => this.snackBarService.showErrorMessage(error)
            );
    }

    public openAuthDialog() {
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

    public isAuthor() {
        if (this.currentUser === undefined) {
            return false;
        }
        let currentUserId = this.currentUser.id;
        let postUserId = this.post.author.id;
        return currentUserId === postUserId;
    }

    private editComment() {
        this.editableComment.body = this.newComment.body;

        this.commentService
            .editComment(this.editableComment)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    if (resp) {
                        this.findIndexPositionAndReplace(this.post.comments, resp.body);
                        this.post.comments = this.sortCommentArray(this.post.comments);
                        this.newComment.body = undefined;
                        this.editableComment = undefined;
                        this.isEditMode = false;
                        this.snackBarService.showUsualMessage("Comment updated!");
                    }
                },
                (error) => this.snackBarService.showErrorMessage(error)
            );
    }

    private findIndexPositionAndReplace(comments: Comment[], editedComment: Comment) {
        let comment = comments
            .find(comment => comment.id === editedComment.id);
        let i = comments.indexOf(comment);
        if (i < 0) return;
        comments.splice(i, 1, editedComment);
    }

    private catchErrorWrapper(obs: Observable<User>) {
        return obs.pipe(
            catchError(() => {
                this.openAuthDialog();
                return empty();
            })
        );
    }

    private sortCommentArray(array: Comment[]): Comment[] {
        return array.sort((a, b) => +new Date(b.createdAt) - +new Date(a.createdAt));
    }

    private setPostData(post: Post) {
        this.post = post;      
        this.setLikePhotos();
    }

    private setLikePhotos() {
        this.likePhotos = [];      
        if ( this.post.reactions.length > 0 ) {          
            this.post.reactions.forEach(r => {
                this.likePhotos.push(r.user.avatar);
            });           
        }
    }
}
