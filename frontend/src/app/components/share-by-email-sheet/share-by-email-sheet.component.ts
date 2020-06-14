import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject } from 'rxjs';
import { ShareByEmailSheetService } from 'src/app/services/share-by-email-sheet.service';
import { PostService } from 'src/app/services/post.service';
import { takeUntil } from 'rxjs/operators';
import { SnackBarService } from 'src/app/services/snack-bar.service';

@Component({
  selector: 'app-share-by-email-sheet',
  templateUrl: './share-by-email-sheet.component.html',
  styleUrls: ['./share-by-email-sheet.component.css']
})
export class ShareByEmailSheetComponent implements OnInit, OnDestroy {
  public email: string = "";
  
  public isSent: boolean = false;
  public loading: boolean = false;
  public submitted: boolean = false;

  public shareForm: FormGroup;

  private unsubscribe$ = new Subject<void>();

  constructor(
    private sheetService: ShareByEmailSheetService,
    private snackbarService: SnackBarService,
    private formBuilder: FormBuilder,
    private postService: PostService
  ) { }

  ngOnInit(): void {
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
    this.postService.sharePostByEmail(this.email)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe((resp) => {
        if(resp) {
          this.snackbarService.showSuccessMessage(`Sent to email: ${this.email}`);
          this.email = undefined;
          this.loading = false;
          this.close();
        }
      }, (err) => {
        this.snackbarService.showErrorMessage(err);
        this.loading = false;
      })
  }

  public close() {
    this.sheetService.close();
  }

  private initFormGroup() {
    return this.formBuilder.group({
      email: ['', [Validators.email]]
    });
  }
}
