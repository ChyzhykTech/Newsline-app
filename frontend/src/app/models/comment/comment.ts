import { User } from '../user';
import { Reaction } from '../reactions/reaction';
import { NegativeReaction } from '../negativeReactions/negativeReaction';

export interface Comment {
    id: number;
    createdAt: Date;
    author: User;
    body: string;
    reactions: Reaction[];
    negativeReactions: NegativeReaction[];
}
