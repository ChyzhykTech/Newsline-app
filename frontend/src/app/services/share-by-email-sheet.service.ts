import { Injectable } from '@angular/core';
import {MatBottomSheet} from '@angular/material/bottom-sheet';
import { ShareByEmailSheetComponent } from '../components/share-by-email-sheet/share-by-email-sheet.component';
import { Post } from '../models/post/post';

@Injectable({
  providedIn: 'root'
})
export class ShareByEmailSheetService {

  constructor(private _bottomSheet: MatBottomSheet) { }

  public open(post: Post) {
    this._bottomSheet.open(ShareByEmailSheetComponent, {data: post});
  }

  public close() {
    this._bottomSheet.dismiss();
  }
}