import { Injectable, OnDestroy } from '@angular/core';
import { ResetPasswordDialogComponent } from '../components/reset-password-dialog/reset-password-dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { takeUntil } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { AuthenticationService } from './auth.service';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class ResetPasswordDialogService implements OnDestroy {
  private unsubscribe$ = new Subject<void>();

  constructor(
    private dialog: MatDialog,
    private authService: AuthenticationService
  ) { }

  public openResetPasswordDialog(withOpenResetPassFields: boolean = false) {
    const dialog = this.dialog.open(ResetPasswordDialogComponent, {
        minWidth: 300,
        autoFocus: true,
        data: withOpenResetPassFields,
        backdropClass: 'dialog-backdrop',
    });

    dialog
        .afterClosed()
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe((result: User) => {
            if (result) {
                this.authService.setUser(result);
            }
        });
  }

  public ngOnDestroy() {
    this.unsubscribe$.next();
    this.unsubscribe$.complete();
  }
}
