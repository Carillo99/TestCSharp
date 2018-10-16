import { Component, OnInit } from '@angular/core';
import { Company } from '../company.model';
import { CompanyService } from '../company.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-company-details',
  templateUrl: './company-details.component.html'
})
export class CompanyDetailsComponent implements OnInit {

  company$: Company;

  constructor(private data: CompanyService, private route: ActivatedRoute) { 
  	this.route.params.subscribe(params => this.company$ = params.id )
  }

  ngOnInit() {
  	this.data.getCompanyByID(this.company$).subscribe(
  		company => this.company$ = company
  	)
  }
}
