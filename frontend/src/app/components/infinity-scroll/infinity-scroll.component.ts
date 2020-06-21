import { Component, Inject, PLATFORM_ID, ElementRef, ViewChild, Output, EventEmitter, Input, OnDestroy, AfterViewInit, ChangeDetectionStrategy } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { InfiniteScrollOptions } from 'src/app/helpers/InfiniteScrollOptions';

@Component({
  selector: 'app-infinity-scroll',
  templateUrl: './infinity-scroll.component.html',
  styleUrls: ['./infinity-scroll.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class InfinityScrollComponent implements AfterViewInit, OnDestroy {

  @Input() options: Partial<InfiniteScrollOptions> = {};
  @Input() loading: boolean;

  @Output() scrolled = new EventEmitter<void>();

  @ViewChild('anchor') anchor: ElementRef<HTMLElement>;

  private observer!: IntersectionObserver;

  constructor(
    private host: ElementRef,
    @Inject(PLATFORM_ID) private platformId: Object
  ) {}

  ngOnDestroy(): void {
    if (isPlatformBrowser(this.platformId)) {
      this.observer.disconnect();
    }
  }

  ngAfterViewInit(): void {
    if (isPlatformBrowser(this.platformId)) {
      this.observer = new IntersectionObserver(([entry]) => entry.isIntersecting && this.scrolled.emit(), {
        root: this.isHostScrollable() ? this.host.nativeElement : null,
        ...this.options
      });
      this.observer.observe(this.anchor.nativeElement);
    }
  }

  private isHostScrollable(): boolean {
    if (isPlatformBrowser(this.platformId)) {
      const style = window.getComputedStyle(this.host.nativeElement);

      return style.getPropertyValue('overflow') === 'auto' || style.getPropertyValue('overflow-y') === 'scroll';
    }

    return false;
  }
}
