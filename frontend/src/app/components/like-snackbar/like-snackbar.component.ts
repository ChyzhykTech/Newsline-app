import { Component, Inject } from '@angular/core';
import { MAT_SNACK_BAR_DATA } from '@angular/material/snack-bar';
import { User } from 'src/app/models/user';
import { Post } from 'src/app/models/post/post';
import { LikeSnackbar } from 'src/app/models/snackbar/like-snackbar';

@Component({
  selector: 'app-like-snackbar',
  templateUrl: './like-snackbar.component.html',
  styleUrls: ['./like-snackbar.component.css']
})
export class LikeSnackbarComponent {
  public fromUser: User;
  public post: Post;

  constructor(
    @Inject(MAT_SNACK_BAR_DATA) private data: LikeSnackbar
  ) { 
    this.fromUser = this.data.fromUser;
    this.post = this.data.post;
  }
}
