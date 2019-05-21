import { ErrorComponent } from './error/error.component';
import { InformationComponent } from './information/information.component';
import { EmployeesComponent } from './employees/employee-list/employees.component';
import { ProductsComponent } from './products/product-list/products.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingComponent } from './landing/landing.component';
import { ReportsComponent } from './reports/reports.component';
import { NavmenuComponent } from './navmenu/navmenu.component';
import { ProductComponent } from './products/product-view/product.component';
import { EmployeeComponent } from './employees/employee-view/employee.component';

const routes: Routes = [
  { path: 'dashboard', component: LandingComponent },
  { path: '', component: LandingComponent },
  {
    path: '',
    component: NavmenuComponent,
    children: [
      { path: 'products', component: ProductsComponent },
      { path: 'product', component: ProductComponent },
      {
        path: 'product/:id',
        component: ProductComponent
      },
      { path: 'reports', component: ReportsComponent },
      { path: 'employees', component: EmployeesComponent },
      {
        path: 'employee/:id',
        component: EmployeeComponent
      },
      { path: 'employee', component: EmployeeComponent },
      { path: 'information', component: InformationComponent }
    ]
  },
  { path: '**', component: ErrorComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
