import { InformationComponent } from './information/information.component';
import { EmployeesComponent } from './employees/employees.component';
import { ProductsComponent } from './products/products.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingComponent } from './landing/landing.component';
import { ReportsComponent } from './reports/reports.component';


const routes: Routes = [
  { path: 'Dashboard', component: LandingComponent },
  { path: 'Reports', component: ReportsComponent },
  { path: 'Products', component: ProductsComponent },
  { path: 'Employees', component: EmployeesComponent },
  { path: 'Information', component: InformationComponent },
  { path: '**', component: LandingComponent },
  { path: '', component: LandingComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
