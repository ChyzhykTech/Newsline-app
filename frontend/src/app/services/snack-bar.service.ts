import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { LikeSnackbarComponent } from '../components/like-snackbar/like-snackbar.component';
import { Post } from '../models/post/post';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class SnackBarService {
    public constructor(private snackBar: MatSnackBar) {}

    public showErrorMessage(error: any) {
        this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' });
    }

    public showUsualMessage(message: any) {
        this.snackBar.open(message, '', { duration: 3000, panelClass: 'usual-snack-bar' });
    }

    public showLikeMessage(post: Post, userName: string, avatar: string) {
        // if(post.author.id !== userId) return;
        this.snackBar.openFromComponent(LikeSnackbarComponent,  
            {duration: 10000 , horizontalPosition: 'right', data: {...post, userName, avatar} });
    }
}
