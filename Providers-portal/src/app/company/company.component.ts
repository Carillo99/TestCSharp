import { Component, OnInit } from '@angular/core';
import {Company} from './company.model';
import {CompanyService} from './company.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html'
})
export class CompanyComponent implements OnInit {

 company$: Company;

  constructor(private data: CompanyService) { }

  ngOnInit() {
  	this.data.getCompany().subscribe(
  		data => this.company$ = data
  	)
  }
}
