import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

import {CompanyProviders} from './company-providers.model';
import {INCOMETAX_API} from '../app.api';

@Injectable({
  providedIn: 'root'
})
export class CompanyProvidersService {


  private accessPointUrl: string = INCOMETAX_API + '/v1/company-providers';

  constructor(private http: HttpClient) { }

  getCompanyProviders(CompanyProvidersQuery): Observable<CompanyProviders>{
    return this.http.get<CompanyProviders>(this.accessPointUrl + '?' + this.Filter(CompanyProvidersQuery))
  }

  Filter(CompanyProvidersQuery)
  {
    var parts = [];
    for (var property in CompanyProvidersQuery) {
      var value = CompanyProvidersQuery[property];
      if (value != null && value != undefined) 
        parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
    }

    return parts.join('&');
  }

  getCompanyProvidersByID(id): Observable<CompanyProviders>{
    return this.http.get<CompanyProviders>(this.accessPointUrl + '/' + id)
  }

  postCompanyProviders(companyProviders: CompanyProviders): Observable<CompanyProviders>{
    return this.http.post<CompanyProviders>(this.accessPointUrl, companyProviders)
  }    
}
