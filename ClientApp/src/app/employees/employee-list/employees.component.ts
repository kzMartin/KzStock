import { EmployeeService } from './../employee.service';
import { Employee } from './../employee';
import { Component, OnInit } from '@angular/core';
import { ModalService } from 'src/app/modal/modal.service';
import { NotificationService } from 'src/app/notifications/notification.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss']
})
export class EmployeesComponent implements OnInit {
  employees: Employee[];
  allEmployees: Employee[];
  employeeDelete: Employee;


  columns = [
    { name: 'id' },
    { name: 'name' },
    { name: 'lastName' },
    { name: 'email' },
    { name: 'enabled' }
  ];

  constructor(
    private employeeService: EmployeeService,
    private modalService: ModalService,
    private notifyService: NotificationService
  ) {}

  ngOnInit() {
    this.getEmployees();
  }

  getEmployees() {
    this.employeeService.getEmployees().subscribe(employees => {
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

  openModal(id: string, employee: Employee) {
    this.modalService.open(id);
    this.employeeDelete = employee;
  }

  closeModal(id: string) {
    this.modalService.close(id);
  }

  closeModalAndDelete(id: string) {
    this.employeeService.delete(this.employeeDelete.id).subscribe(x => {
      this.notifyService.showInfo(
        'Employee ' + this.employeeDelete.name + ' was delete',
        'Information'
      );
      this.getEmployees();
      this.modalService.close(id);
    });
  }
}
