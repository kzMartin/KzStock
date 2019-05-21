import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NotificationService } from 'src/app/notifications/notification.service';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-form-employee-edit',
  templateUrl: './form-employee-edit.component.html',
  styleUrls: ['../form-employee-add/form-employee-add.component.scss']
})
export class FormEmployeeEditComponent implements OnInit {
  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private employeeService: EmployeeService,
    private notifyService: NotificationService
  ) {}

  employeeForm = this.fb.group({
    id: [13],
    name: ['', Validators.required],
    lastName: ['', Validators.required],
    email: ['', Validators.required],
    enabled: [false]
  });

  ngOnInit() {
    this.employeeService
      .getEmployee(this.route.snapshot.params.id)
      .subscribe(employee => {
        this.employeeForm.patchValue({
          id: employee.id,
          name: employee.name,
          lastName: employee.lastName,
          email: employee.email,
          enabled: employee.enabled
        });
      });
  }

  onSubmit() {
    this.employeeService.update(this.employeeForm.value).subscribe(employee => {
      this.notifyService.showSuccess(
        'Employee edited successfully !!',
        'Notification'
      );
      this.router.navigate(['/employees']);
    });
  }
}
