import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-like-tooltip',
  templateUrl: './like-tooltip.component.html',
  styleUrls: ['./like-tooltip.component.sass']
})
export class LikeTooltipComponent {
  @Input() public photos = [];

  public hasLikes() {
    return this.photos.length > 0;
  }
}
