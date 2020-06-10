import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Subject } from 'rxjs';
import { MatDialogRef } from '@angular/material/dialog';
import { checkIfMatchingPasswords } from 'src/app/validators/check-if-matching-passwords.validator';
import { AuthenticationService } from 'src/app/services/auth.service';
import { UserResetPasswordDto } from 'src/app/models/auth/user-reset-password-dto';
import { UserService } from 'src/app/services/user.service';
import { SnackBarService } from 'src/app/services/snack-bar.service';
import { User } from 'src/app/models/user';
import { takeUntil } from 'rxjs/operators';

@Component({
  selector: 'app-reset-password-dialog',
  templateUrl: './reset-password-dialog.component.html',
  styleUrls: ['./reset-password-dialog.component.sass']
})
export class ResetPasswordDialogComponent implements OnInit {
  public user = {} as User;
  public oldPassword: string;
  public password: string;
  public confirmPassword: string;

  public hidePass = true;
  public authForm: FormGroup;
  public submitted = false;

  private unsubscribe$ = new Subject<void>();

  constructor( 
    private dialogRef: MatDialogRef<ResetPasswordDialogComponent>,
    private formBuilder: FormBuilder,
    private authService: AuthenticationService,
    private snackBarService: SnackBarService,
    private userService: UserService
  ) { }

  public ngOnInit(): void {
    this.authForm = this.initFormGroup();
    this.authService
            .getUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => (this.user = this.userService.copyUser(user)), (error) => this.snackBarService.showErrorMessage(error));
  }

  get f() { return this.authForm.controls; }

  public ngOnDestroy() {
    this.unsubscribe$.next();
    this.unsubscribe$.complete();
  }

  public reset() { 
    this.submitted = true;
    if (this.authForm.invalid) return;
    let userPasswords: UserResetPasswordDto = {
      userId: this.user.id,
      oldPassword: this.oldPassword, 
      newPassword: this.password, 
      confirmPassword: this.confirmPassword
    };
    this.authService.resetPassword(userPasswords);
  }

  public close() {
      this.dialogRef.close(false);
  }

  private initFormGroup() {
    return this.formBuilder.group({
      oldPassword: ['', [Validators.required]],
      password: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(16)]],
      confirmPassword: ['', [Validators.required]]
    }, {validator: checkIfMatchingPasswords('password', 'confirmPassword')});
  }
}
