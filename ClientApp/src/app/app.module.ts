import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeesComponent } from './employees/employee-list/employees.component';
import { InformationComponent } from './information/information.component';
import { LandingComponent } from './landing/landing.component';
import { NavmenuComponent } from './navmenu/navmenu.component';
import { ProductsComponent } from './products/product-list/products.component';
import { ReportsComponent } from './reports/reports.component';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ProductComponent } from './products/product-view/product.component';
import { FormProductComponent } from './products/form-product-add/form-product.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ModalComponent } from './modal/modal.component';
import { FormProductEditComponent } from './products/form-product-edit/form-product-edit.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { ErrorComponent } from './error/error.component';
import { EmployeeComponent } from './employees/employee-view/employee.component';
import { FormEmployeeAddComponent } from './employees/form-employee-add/form-employee-add.component';
import { FormEmployeeEditComponent } from './employees/form-employee-edit/form-employee-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    LandingComponent,
    ReportsComponent,
    ProductsComponent,
    EmployeesComponent,
    InformationComponent,
    NavmenuComponent,
    ProductComponent,
    FormProductComponent,
    ModalComponent,
    FormProductEditComponent,
    ErrorComponent,
    EmployeeComponent,
    FormEmployeeAddComponent,
    FormEmployeeEditComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    AngularFontAwesomeModule,
    NgxDatatableModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({positionClass: 'toast-bottom-center'})
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
