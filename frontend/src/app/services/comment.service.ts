import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { NewComment } from '../models/comment/new-comment';
import { Comment } from '../models/comment/comment';
import { NewReaction } from '../models/reactions/newReaction';
import { NewNegativeReaction } from '../models/negativeReactions/newNegativeReaction';

@Injectable({ providedIn: 'root' })
export class CommentService {
    public routePrefix = '/api/comments';

    constructor(private httpService: HttpInternalService) {}

    public createComment(post: NewComment) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}`, post);
    }

    public deleteComment(commentId: number) {
        return this.httpService.deleteFullRequest(`${this.routePrefix}/`+ commentId);
    }

    public likeComment(reaction: NewReaction) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}/like`, reaction);
    }

    public dislikeComment(reaction: NewNegativeReaction) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}/dislike`, reaction);
    }
}
