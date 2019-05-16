import { Component, OnInit } from '@angular/core';
import { LocationStrategy } from '@angular/common';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.scss']
})
export class EmployeeComponent implements OnInit {

  constructor(private url: LocationStrategy) { }

  isExist = false;

  ngOnInit() {
    if (this.url.path() === '/employee') {
      this.isExist = false;
    } else {
      this.isExist = true;
    }
  }

}
