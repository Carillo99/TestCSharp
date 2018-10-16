import { Component, OnInit } from '@angular/core';
import { Company } from '../company.model';
import { CompanyService } from '../company.service';
import { Router } from '@angular/router';
import { UF } from '../../enum/uf.enum';

@Component({
  selector: 'app-company-create',
  templateUrl: './company-create.component.html'
})
export class CompanyCreateComponent implements OnInit {

  company$: Array<Company> = [];
  currentCompany: Company = new Company();
  UF = UF;  
  constructor(private data: CompanyService, private router: Router) { }

  ngOnInit() {
  
  }

  addTaxpayer() {
     this.data
    .postCompany(this.currentCompany)
    .subscribe(company => {
      if (!this.currentCompany.id) {
        this.company$.push(company);
      }
      this.router.navigate(['/company']);
    });
  }
}