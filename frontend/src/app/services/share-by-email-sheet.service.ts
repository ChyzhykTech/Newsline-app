import { Injectable } from '@angular/core';
import {MatBottomSheet, MatBottomSheetRef} from '@angular/material/bottom-sheet';
import { ShareByEmailSheetComponent } from '../components/share-by-email-sheet/share-by-email-sheet.component';

@Injectable({
  providedIn: 'root'
})
export class ShareByEmailSheetService {

  constructor(
    private _bottomSheet: MatBottomSheet,
    private _bottomSheetRef: MatBottomSheetRef<ShareByEmailSheetComponent>
  ) { }

  public open() {
    this._bottomSheet.open(ShareByEmailSheetComponent);
  }

  public close() {
    this._bottomSheetRef.dismiss();
  }
}
