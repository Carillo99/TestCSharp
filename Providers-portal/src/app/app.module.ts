import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CompanyProvidersComponent } from './company-providers/company-providers.component';
import { CompanyComponent } from './company/company.component';
import { CompanyCreateComponent } from './company/company-create/company-create.component';
import { CompanyDetailsComponent } from './company/company-details/company-details.component';
import { CompanyProvidersCreateComponent } from './company-providers/company-providers-create/company-providers-create.component';
import { CompanyProvidersDetailsComponent } from './company-providers/company-providers-details/company-providers-details.component';
import { PhoneProvidersComponent } from './phone-providers/phone-providers.component';
//import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

@NgModule({
  declarations: [
    AppComponent,
    CompanyProvidersComponent,
    CompanyComponent,
    CompanyCreateComponent,
    CompanyDetailsComponent,
    CompanyProvidersCreateComponent,
    CompanyProvidersDetailsComponent,
    PhoneProvidersComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
   // BsDatepickerModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
