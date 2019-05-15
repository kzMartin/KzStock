import { EmployeeService } from './../employee.service';
import { Employee } from './../employee';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss']
})
export class EmployeesComponent implements OnInit {
  employees: Employee[];
  allEmployees: Employee[];

  columns = [
    { name: 'id' },
    { name: 'name' },
    { name: 'lastName' },
    { name: 'email' },
    { name: 'enabled' }
  ];

  constructor(private employeeService: EmployeeService) {}

  ngOnInit() {
    this.getEmployees();
  }

  getEmployees() {
    this.employeeService.getProducts().subscribe(employees => {
      this.employees = employees;
      this.allEmployees = employees;
    });
  }

  updateFilter(event) {
    const val = event.target.value.toLowerCase();

    const result = this.allEmployees.filter(product => {
      return product.name.toLowerCase().includes(val);
    });

    if (val !== '') {
      this.employees = result;
    } else {
      this.employees = this.allEmployees;
    }
  }
}
