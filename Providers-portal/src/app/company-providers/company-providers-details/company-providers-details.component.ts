import { Component, OnInit } from '@angular/core';
import { CompanyProviders } from '../company-providers.model';
import { CompanyProvidersService } from '../company-providers.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-company-providers-details',
  templateUrl: './company-providers-details.component.html',
})
export class CompanyProvidersDetailsComponent implements OnInit {


  companyProviders$: CompanyProviders

  constructor(private data: CompanyProvidersService, private route: ActivatedRoute) { 
  	this.route.params.subscribe(params => this.companyProviders$ = params.id )
  }

  ngOnInit() {
  	this.data.getCompanyProvidersByID(this.companyProviders$).subscribe(
  		companyProviders => this.companyProviders$ = companyProviders
  	)
  }
}
