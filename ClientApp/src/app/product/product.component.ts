import { Component, OnInit } from '@angular/core';
import { LocationStrategy } from '@angular/common';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {
  constructor(private url: LocationStrategy) {}

  isExist = false;

  ngOnInit() {
    if (this.url.path() === '/product') {
      this.isExist = false;
    } else {
      this.isExist = true;
    }
  }
}
