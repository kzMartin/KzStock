import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/products/product.service';

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
    private productService: ProductService
  ) {}

  productForm = this.fb.group({
    name: ['', Validators.required],
    unitPrice: ['', Validators.required],
    stock: ['', Validators.required]
  });

  onSubmit() {
    this.productService.create(this.productForm.value).subscribe(product => {
      console.log(product), this.router.navigate(['/products']);
    });
  }
}