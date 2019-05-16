import { Component } from '@angular/core';
import { Validators } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/products/product.service';
import { NotificationService } from 'src/app/notifications/notification.service';

@Component({
  selector: 'app-form-product',
  templateUrl: './form-product.component.html',
  styleUrls: ['./form-product.component.scss']
})
export class FormProductComponent {
  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private productService: ProductService,
    private notifyService: NotificationService
  ) {}

  productForm = this.fb.group({
    name: ['', Validators.required],
    unitPrice: ['', Validators.required],
    stock: ['', Validators.required]
  });

  onSubmit() {
    console.log(this.productForm.value);
    this.productService.create(this.productForm.value).subscribe(product => {
      this.notifyService.showSuccess('Product added successfully !!', 'Notification');
      this.router.navigate(['/products']);
    });
  }
}
