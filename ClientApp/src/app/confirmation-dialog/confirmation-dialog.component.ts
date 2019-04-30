import { ProductsComponent } from './../products/products.component';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-confirmation-dialog',
  templateUrl: './confirmation-dialog.component.html',
  styleUrls: ['./confirmation-dialog.component.scss']
})
export class ConfirmationDialogComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
   confirm() {
    console.log('confirm');
   }

   cancel() {
    console.log('cancel');
   }
}
