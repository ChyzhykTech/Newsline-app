import { Component, OnInit, Inject, OnDestroy } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogType } from '../../models/common/auth-dialog-type';
import { Subject } from 'rxjs';
import { AuthenticationService } from '../../services/auth.service';
import { takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    templateUrl: './auth-dialog.component.html',
    styleUrls: ['./auth-dialog.component.sass']
})
export class AuthDialogComponent implements OnInit, OnDestroy {
    public dialogType = DialogType;
    public avatar: string;

    public hidePass = true;
    public title: string;
    private unsubscribe$ = new Subject<void>();

    public submitted = false;
    public authForm: FormGroup;

    constructor(
        private dialogRef: MatDialogRef<AuthDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private authService: AuthenticationService,
        private snackBarService: SnackBarService,
        private formBuilder: FormBuilder
    ) {}

    get f() { return this.authForm.controls; }

    public ngOnInit() {
        this.avatar = 'https://avatars.mds.yandex.net/get-ott/374297/2a000001616b87458162c9216ccd5144e94d/orig';
        this.title = this.data.dialogType === DialogType.SignIn ? 'Sign In' : 'Sign Up';
        this.authForm = this.data.dialogType === DialogType.SignIn ? this.buildSignInFormGroup() : this.buildSignUpFormGroup();
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public close() {
        this.dialogRef.close(false);
    }

    public signIn() {
        this.submitted = true;
        if (this.authForm.invalid)  return;

        let password = this.authForm.value.password;
        let email = this.authForm.value.email;
        this.authService
            .login({ email: email, password: password })
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((response) => 
             {this.dialogRef.close(response); this.submitted = false;}, (error) => this.snackBarService.showErrorMessage(error));
    }

    public signUp() {
        this.submitted = true;
        if (this.authForm.invalid)  return;

        let userName = this.authForm.value.userName;
        let password = this.authForm.value.password;
        let email = this.authForm.value.email;
        this.authService
            .register({ userName: userName, password: password, email: email, avatar: this.avatar })
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((response) => {this.dialogRef.close(response); this.submitted = false;}, (error) => this.snackBarService.showErrorMessage(error));
    }

    private buildSignInFormGroup() {
        return this.formBuilder.group({
            email: ['', [Validators.required, Validators.email]],
            password: ['', [Validators.required]],
        });
    }

    private buildSignUpFormGroup() {
        return this.formBuilder.group({
            email: ['', [Validators.required, Validators.email]],
            userName: ['', [Validators.required, Validators.minLength(3)]],
            password: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(16)]],
        });
    }
}
