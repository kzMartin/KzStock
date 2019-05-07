import { Component, OnInit } from '@angular/core';
import { Product } from './product';
import { ProductService } from './product.service';
import { ModalService } from '../modal/modal.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  products: Product[];
  allProducts: Product[];
  confirmationDialog = false;

  columns = [
    { name: 'id' },
    { name: 'name' },
    { name: 'stock' },
    { name: 'unitPrice' }
  ];

  productDelete: Product;

  constructor(
    private productService: ProductService,
    private modalService: ModalService
  ) {}

  ngOnInit() {
    this.getProducts();
  }

  getProducts() {
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

  openModal(id: string, product: Product) {
    this.modalService.open(id);
    this.productDelete = product;
  }

  closeModal(id: string) {
    this.modalService.close(id);
  }

  closeModalAndDelete(id: string) {
    this.productService.delete(this.productDelete.id).subscribe(x => {
      this.getProducts();
      this.modalService.close(id);
    });
  }
}
