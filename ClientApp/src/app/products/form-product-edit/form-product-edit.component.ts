import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/products/product.service';
import { Product } from 'src/app/products/product';

@Component({
  selector: 'app-form-product-edit',
  templateUrl: './form-product-edit.component.html',
  styleUrls: ['../form-product-add/form-product.component.scss']
})
export class FormProductEditComponent implements OnInit {
  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private productService: ProductService
  ) {}

  productForm = this.fb.group({
    id: [''],
    name: ['', Validators.required],
    unitPrice: ['', Validators.required],
    stock: ['', Validators.required]
  });

  ngOnInit() {
    this.productService
      .getProduct(this.route.snapshot.params.id)
      .subscribe(product => {
        this.productForm.patchValue({
          id: product.id,
          name: product.name,
          unitPrice: product.unitPrice,
          stock: product.stock
        });
      });
  }

  onSubmit() {
    this.productService.update(this.productForm.value).subscribe(product => {
      this.router.navigate(['/products']);
    });
  }
}
