import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeesComponent } from './employees/employees.component';
import { InformationComponent } from './information/information.component';
import { LandingComponent } from './landing/landing.component';
import { NavmenuComponent } from './navmenu/navmenu.component';
import { ProductsComponent } from './products/products.component';
import { ReportsComponent } from './reports/reports.component';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ProductComponent } from './product/product.component';


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
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    AngularFontAwesomeModule,
    NgxDatatableModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
