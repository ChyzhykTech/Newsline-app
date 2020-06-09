import { Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { AuthenticationService } from './auth.service';
import { SnackBarService } from './snack-bar.service';

@Injectable({
  providedIn: 'root'
})
export class PostHubService  {
  private hubConnection: HubConnection;

  constructor(
    private authService: AuthenticationService,
    private snackBarService: SnackBarService
  ) { 
    this.startHub();
  }

  public stopHub(){
    this.hubConnection.stop()
        .catch((error) => this.snackBarService.showErrorMessage(error));
  }

  public getConnection() {
      return this.hubConnection;
  }

  public reloadConnection() {
    this.hubConnection.stop()
      .then(resp => this.startHub())
      .catch(err => this.snackBarService.showErrorMessage(err));
  }

  private startHub() {
    this.hubConnection = new HubConnectionBuilder()
      .withUrl("https://localhost:44344/notifications/post", this.getHubOptions())
      .build();

      this.hubConnection.start()
        .catch((error) => this.snackBarService.showErrorMessage(error));
  }

  private getHubOptions() {
    let options = (this.prepareToken() === undefined) ? {} :{
      accessTokenFactory: () => this.prepareToken()
    };
    return options;
  }

  private prepareToken() {
    let token: string = this.authService.accessToken;
    if(token === null) return;
    let res = token.slice(1, token.length - 1);
    return res;
  }
}
