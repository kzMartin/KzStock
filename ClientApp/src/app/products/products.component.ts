import { Component, OnInit } from '@angular/core';
import { Product } from './product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  columnDefs = [
    { headerName: 'Id', field: 'id', sortable: true, filter: true },
    { headerName: 'Name', field: 'name', sortable: true, filter: true },
    { headerName: 'Stock', field: 'stock', sortable: true, filter: true },
    {
      headerName: 'Unit Price',
      field: 'unitPrice',
      sortable: true,
      filter: true
    }
  ];

  products: Product[];

  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.productService
      .getProducts()
      .subscribe(products => (this.products = products));
  }
}
