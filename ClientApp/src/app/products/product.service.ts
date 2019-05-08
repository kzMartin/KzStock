import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from './product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  constructor(private http: HttpClient) {}

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>('/api/products/all');
  }

  create(product: Product) {
    return this.http.post('/api/products/add', product);
  }

  delete(id: number) {
    const httpParams = new HttpParams().set('id', id.toString());
    const options = { params: httpParams };
    return this.http.delete('/api/products/delete/', options);
  }
}
