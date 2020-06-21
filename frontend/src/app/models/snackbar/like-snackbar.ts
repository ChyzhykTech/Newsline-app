import { User } from '../user';
import { Post } from '../post/post';

export interface LikeSnackbar {
    fromUser: User;
    post: Post;
}