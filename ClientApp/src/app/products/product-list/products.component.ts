import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { ProductService } from '../product.service';
import { ModalService } from '../../modal/modal.service';
import { NotificationService } from 'src/app/notifications/notification.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  products: Product[];
  allProducts: Product[];
  confirmationDialog = false;
  loadingIndicator = true;

  columns = [
    { name: 'id' },
    { name: 'name' },
    { name: 'stock' },
    { name: 'unitPrice' }
  ];

  productDelete: Product;

  constructor(
    private productService: ProductService,
    private modalService: ModalService,
    private notifyService: NotificationService
  ) {}

  ngOnInit() {
    this.getProducts();
  }

  getProducts() {
    this.productService.getProducts().subscribe(products => {
      this.loadingIndicator = false;
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

  openModal(id: string, product: Product) {
    this.modalService.open(id);
    this.productDelete = product;
  }

  closeModal(id: string) {
    this.modalService.close(id);
  }

  closeModalAndDelete(id: string) {
    this.productService.delete(this.productDelete.id).subscribe(x => {
      this.notifyService.showInfo('Product ' + this.productDelete.name + ' was delete', 'Information');
      this.getProducts();
      this.modalService.close(id);
    });
  }
}
