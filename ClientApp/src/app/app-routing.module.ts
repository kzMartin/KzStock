import { InformationComponent } from './information/information.component';
import { EmployeesComponent } from './employees/employees.component';
import { ProductsComponent } from './products/products.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingComponent } from './landing/landing.component';
import { ReportsComponent } from './reports/reports.component';
import { NavmenuComponent } from './navmenu/navmenu.component';


const routes: Routes = [
  { path: 'dashboard', component: LandingComponent },
  { path: 'navmenu', component: NavmenuComponent },
  { path: 'reports', component: ReportsComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'employees', component: EmployeesComponent },
  { path: 'information', component: InformationComponent },
  { path: '**', component: LandingComponent },
  { path: '', component: LandingComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
