import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { LikeSnackbarComponent } from '../components/like-snackbar/like-snackbar.component';
import { LikeSnackbar } from '../models/snackbar/like-snackbar';

@Injectable({ providedIn: 'root' })
export class SnackBarService {
    public constructor(private snackBar: MatSnackBar) {}

    public showErrorMessage(error: any) {
        this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' });
    }

    public showUsualMessage(message: any) {
        this.snackBar.open(message, '', { duration: 3000, panelClass: 'usual-snack-bar' });
    }

    public showSuccessMessage(message: any) {
        this.snackBar.open(message, '', { duration: 3000, panelClass: 'success-snack-bar' });
    }

    public showLikeMessage(likeSnackbar: LikeSnackbar) {
        this.snackBar.openFromComponent(LikeSnackbarComponent,  
            {duration: 3000 , horizontalPosition: 'right', data: likeSnackbar });
    }
}
