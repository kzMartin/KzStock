import { Component, OnInit } from '@angular/core';
import { Product } from './product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  products: Product[];

  columns = [
    { prop: 'Id' },
    { name: 'Name' },
    { name: 'UnitPrice' },
    { name: 'Stock' }
  ];

  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.productService
      .getProducts()
      .subscribe(products => (this.products = products));
  }
}
