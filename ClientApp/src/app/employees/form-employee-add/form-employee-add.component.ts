import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from '../employee.service';
import { NotificationService } from 'src/app/notifications/notification.service';

@Component({
  selector: 'app-form-employee-add',
  templateUrl: './form-employee-add.component.html',
  styleUrls: ['./form-employee-add.component.scss']
})
export class FormEmployeeAddComponent {

  constructor(private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private employeeService: EmployeeService,
    private notifyService: NotificationService) { }

    employeeForm = this.fb.group({
      name: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.required],
      enabled: [true]
    });

    onSubmit() {
      this.employeeService.create(this.employeeForm.value).subscribe(employee => {
        this.notifyService.showSuccess('Employee added successfully !!', 'Notification');
        this.router.navigate(['/employees']);
      });
    }

}
