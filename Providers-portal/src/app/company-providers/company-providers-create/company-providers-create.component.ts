import { Component, OnInit, Input } from '@angular/core';
import { CompanyProviders } from '../company-providers.model';
import { CompanyProvidersService } from '../company-providers.service';
import { Router } from '@angular/router';
import { Company } from '../../company/company.model';

import { PhoneProviders } from '../../phone-providers/phone-providers.model';
import { CompanyService} from '../../company/company.service';

import { FormBuilder, FormGroup, FormArray, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-company-providers-create',
  templateUrl: './company-providers-create.component.html'
})
export class CompanyProvidersCreateComponent implements OnInit {

  companyProviders$: Array<CompanyProviders> = [];
  currentCompanyProviders: CompanyProviders = new CompanyProviders();
  company: Company;
 
  constructor(private data: CompanyProvidersService, private dataCompany: CompanyService,  private router: Router) {
    this.dataCompany.getCompany().subscribe(dataCompany => this.company = dataCompany)
  }

  ngOnInit() {}

  addTaxpayer() {
     this.data
    .postCompanyProviders(this.currentCompanyProviders)
    .subscribe(companyProviders => {
      
      if (!this.currentCompanyProviders.id) {
        this.companyProviders$.push(companyProviders);
      } 
      this.router.navigate(['/create/'+companyProviders.id+'/phone-providers']);
    });    
  }
 
}

function verificAge(){
  if ((this.currentCompanyProviders.ativo == true) && (this.currentCompanyProviders.company.uf ==18) && (this.currentCompanyProviders.age < 18)) {
    return true;  
  }else{
      return false;
  } 
}