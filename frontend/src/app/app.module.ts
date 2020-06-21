import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { ErrorInterceptor } from './helpers/error.interceptor';
import { RouterModule } from '@angular/router';
import { AppRoutes } from './app.routes';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MainThreadComponent } from './components/main-thread/main-thread.component';
import { PostComponent } from './components/post/post.component';
import { HomeComponent } from './components/home/home.component';
import { UserProfileComponent } from './components/user-profile/user-profile.component';
import { AuthDialogComponent } from './components/auth-dialog/auth-dialog.component';
import { CommentComponent } from './components/comment/comment.component';
import { MaterialComponentsModule } from './components/common/material-components.module';
import { LikeTooltipComponent } from './components/like-tooltip/like-tooltip.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { LikeSnackbarComponent } from './components/like-snackbar/like-snackbar.component';
import { ResetPasswordDialogComponent } from './components/reset-password-dialog/reset-password-dialog.component';
import { ShareByEmailSheetComponent } from './components/share-by-email-sheet/share-by-email-sheet.component';
import { MatBottomSheetModule, MatBottomSheetRef } from '@angular/material/bottom-sheet';

@NgModule({
    declarations: [AppComponent, MainThreadComponent, PostComponent, HomeComponent, UserProfileComponent, AuthDialogComponent, CommentComponent, LikeTooltipComponent, LikeSnackbarComponent, ResetPasswordDialogComponent, ShareByEmailSheetComponent],
    imports: [BrowserModule, BrowserAnimationsModule, HttpClientModule, MaterialComponentsModule, RouterModule.forRoot(AppRoutes), FormsModule, ReactiveFormsModule, NgbModule, MatBottomSheetModule],
    exports: [MaterialComponentsModule],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
        { provide: MatBottomSheetRef, useValue: {} }
    ],
    bootstrap: [AppComponent]
})
export class AppModule {}
