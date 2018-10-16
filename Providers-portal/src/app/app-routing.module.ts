import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { CompanyProvidersComponent } from './company-providers/company-providers.component';
import { CompanyProvidersCreateComponent } from './company-providers/company-providers-create/company-providers-create.component';
import { CompanyProvidersDetailsComponent } from './company-providers/company-providers-details/company-providers-details.component';
import { CompanyComponent } from './company/company.component';
import { CompanyCreateComponent } from './company/company-create/company-create.component';
import { CompanyDetailsComponent } from './company/company-details/company-details.component';
import { PhoneProvidersComponent } from './phone-providers/phone-providers.component';

const routes: Routes = [

	{path: '', component: CompanyProvidersComponent},
	{path: 'create', component: CompanyProvidersCreateComponent},
	{path: 'detail/:id', component: CompanyProvidersDetailsComponent},
	{path: 'company', component: CompanyComponent},
	{path: 'company/create', component: CompanyCreateComponent},
	{path: 'company/detail/:id', component: CompanyDetailsComponent},
	{path: 'create/:companyProvidersId/phone-providers', component: PhoneProvidersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
