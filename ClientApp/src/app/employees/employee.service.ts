import { Employee } from './employee';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ErrorHandlerService } from './../error-handler.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  constructor(
    private http: HttpClient,
    private errorHandler: ErrorHandlerService
  ) {}

  getProducts(): Observable<Employee[]> {
    return this.http.get<Employee[]>('/api/employees/all');
  }

  create(employee: Employee) {
    return this.http.post('/api/employees/add', employee).pipe(
      catchError(error => {
        this.errorHandler.errorHandlerAdd(error.status, employee);
        return throwError(error.status);
      })
    );
  }

  delete(id: number) {
    const httpParams = new HttpParams().set('id', id.toString());
    const options = { params: httpParams };
    return this.http.delete('/api/employees/delete/', options);
  }
}
