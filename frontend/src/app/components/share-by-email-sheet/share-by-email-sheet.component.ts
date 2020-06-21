import { Component, OnInit, OnDestroy, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject } from 'rxjs';
import { ShareByEmailSheetService } from 'src/app/services/share-by-email-sheet.service';
import { PostService } from 'src/app/services/post.service';
import { takeUntil } from 'rxjs/operators';
import { SnackBarService } from 'src/app/services/snack-bar.service';
import { MAT_BOTTOM_SHEET_DATA } from '@angular/material/bottom-sheet';
import { Post } from 'src/app/models/post/post';
import { SharePostByEmail } from 'src/app/models/post/share-post-by-email';

@Component({
  selector: 'app-share-by-email-sheet',
  templateUrl: './share-by-email-sheet.component.html',
  styleUrls: ['./share-by-email-sheet.component.sass']
})
export class ShareByEmailSheetComponent implements OnInit, OnDestroy {
  public email: string = "";
  
  public isSent: boolean = false;
  public loading: boolean = false;
  public submitted: boolean = false;

  public shareForm: FormGroup;
  private post: Post;
  private unsubscribe$ = new Subject<void>();

  constructor(
    @Inject(MAT_BOTTOM_SHEET_DATA) private data: Post,
    private sheetService: ShareByEmailSheetService,
    private snackbarService: SnackBarService,
    private formBuilder: FormBuilder,
    private postService: PostService
  ) {  }

  ngOnInit(): void {
    this.post = this.data;
    this.shareForm = this.initFormGroup();
  }

  public ngOnDestroy() {
    this.unsubscribe$.next();
    this.unsubscribe$.complete();
  }

  get f() { return this.shareForm.controls; }

  public share() {
    this.submitted = true;
    if (this.shareForm.invalid) return;

    this.loading = true;

    let sharePost = {
      post: this.post,
      email: this.email
    } as SharePostByEmail;

    console.log(sharePost);

    this.postService.sharePostByEmail(sharePost)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe((resp) => {
        if(resp) {
          this.snackbarService.showSuccessMessage(`Post was sent to email: ${this.email}`);
          this.email = undefined;
          this.loading = false;
          this.cancel();
        }
      }, (err) => {
        this.snackbarService.showErrorMessage(err);
        this.loading = false;
      })
  }

  public cancel() {
    this.sheetService.close();
  }

  private initFormGroup() {
    return this.formBuilder.group({
      email: ['', [Validators.email, Validators.required]]
    });
  }
}
