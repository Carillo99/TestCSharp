import { Component, OnInit } from '@angular/core';
import { CompanyProviders } from './company-providers.model';
import { CompanyProvidersService } from './company-providers.service';


@Component({
  selector: 'app-company-providers',
  templateUrl: './company-providers.component.html'
})
export class CompanyProvidersComponent implements OnInit {

  companyProviders$: CompanyProviders;
  filter: any = {}; 

  constructor(private data: CompanyProvidersService) { }

  ngOnInit() {

    this.populateVehicles();
  }

  private populateVehicles() {
    this.data.getCompanyProviders(this.filter).subscribe(
  		data => this.companyProviders$ = data
  	)
  }

  onFilterChange() {
    this.populateVehicles();
  }

  resetFilter() {
    this.filter = {};
    this.onFilterChange();
  }

}
