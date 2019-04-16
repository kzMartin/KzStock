import { Component, OnInit, ViewChild } from '@angular/core';
import { DatatableComponent } from '@swimlane/ngx-datatable';
import { Product } from './product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  products: Product[];
  allProducts: Product[];

  columns = [
    { name: 'id' },
    { name: 'name' },
    { name: 'stock' },
    { name: 'unitPrice' }
  ];

  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.productService.getProducts().subscribe(products => {
      this.products = products;
      this.allProducts = products;
    });
  }

  updateFilter(event) {
    const val = event.target.value.toLowerCase();

    const result = this.allProducts.filter(product => {
      return product.name.toLowerCase().includes(val);
    });

    if (val !== '') {
      this.products = result;
    } else {
      this.products = this.allProducts;
    }
  }
  edit(product: Product) {
    alert('edit works');
  }
  delete(product: Product) {
    alert('delete works');
  }
}
