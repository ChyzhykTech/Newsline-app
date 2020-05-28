import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-like-tooltip',
  templateUrl: './like-tooltip.component.html',
  styleUrls: ['./like-tooltip.component.sass']
})
export class LikeTooltipComponent implements OnInit {
  @Input() public photos = [];

  constructor() { }

  ngOnInit(): void {
  }

}
