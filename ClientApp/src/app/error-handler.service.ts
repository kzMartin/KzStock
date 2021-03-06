import { Injectable } from '@angular/core';
import { NotificationService } from './notifications/notification.service';

@Injectable({
  providedIn: 'root'
})
export class ErrorHandlerService {
  constructor(private notifyService: NotificationService) {}

  errorHandlerUpdate(error, item) {
    this.notifyService.showError(
      'An error occurred while trying to edit ' + item.name,
      'Error ' + error
    );
  }

  errorHandlerAdd(error, item) {
    this.notifyService.showError(
      'An error occurred while trying to add ' + item.name,
      'Error ' + error
    );
  }

  errorHandlerGet(error) {
    this.notifyService.showError(
      'An error occurred while trying get this employee ',
      'Error ' + error
    );
  }

  errorHandlerGetAll(error) {
    this.notifyService.showError(
      'An error occurred while trying get all employees ',
      'Error ' + error
    );
  }
}
