import { Component, OnInit } from '@angular/core';
import { LocationStrategy } from '@angular/common';
import { NotificationService } from 'src/app/notifications/notification.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {
  constructor(private url: LocationStrategy, private notifyService : NotificationService) {}

  isExist = false;

  ngOnInit() {
    if (this.url.path() === '/product') {
      this.isExist = false;
    } else {
      this.isExist = true;
    }
  }

  showToaster() {
    this.notifyService.showSuccess("Data shown successfully !!", "Notification")
  }
}
