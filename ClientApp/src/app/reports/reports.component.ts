import { EmployeeService } from './../employees/employee.service';
import { ProductService } from 'src/app/products/product.service';
import { Product } from './../products/product';
import { Component, OnInit } from '@angular/core';
import { Employee } from '../employees/employee';

@Component({
  selector: 'app-reports',
  templateUrl: './reports.component.html',
  styleUrls: ['./reports.component.scss']
})
export class ReportsComponent implements OnInit {

  employees: Employee[];
  products: Product[];

  columns = [
    { name: 'name' },
  ];

  constructor(private productService: ProductService, private employeeService: EmployeeService) {}

  ngOnInit() {
    this.getProducts();
    this.getEmployees();
  }

  getProducts() {
    this.productService.getProducts().subscribe(products => {
      this.products = products;
    });
  }

  getEmployees() {
    this.employeeService.getEmployees().subscribe(employees => {
      this.employees = employees;
    });
  }
}
