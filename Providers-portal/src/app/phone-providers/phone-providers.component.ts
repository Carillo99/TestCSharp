import { Component, OnInit } from '@angular/core';
import { PhoneProviders } from './phone-providers.model';
import { PhoneProvidersService } from './phone-providers.service';
import { FormBuilder, FormGroup, FormArray, FormControl } from '@angular/forms';
import { CompanyProviders } from '../company-providers/company-providers.model';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-phone-providers',
  templateUrl: './phone-providers.component.html'
})
export class PhoneProvidersComponent implements OnInit {
  
  companyProviders: CompanyProviders;
  phoneProviders$: Array<PhoneProviders> = [];
  currentPhoneProviders: PhoneProviders = new PhoneProviders();

  constructor(private data: PhoneProvidersService, private route: ActivatedRoute) { 
  this.route.params.subscribe(params => this.companyProviders = params.companyProvidersId )
  }

  ngOnInit() {
  }

  addPhone() {
     this.data
    .postPhone(this.currentPhoneProviders, this.companyProviders )
    .subscribe(phoneProviders => {
      if (!this.currentPhoneProviders.id) {
        this.phoneProviders$.push(phoneProviders);
      } 
    });
  } 
}