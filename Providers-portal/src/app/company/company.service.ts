import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

import { Company } from './company.model';
import { INCOMETAX_API } from '../app.api';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  private accessPointUrl: string = INCOMETAX_API + '/v1/company';

  constructor(private http: HttpClient) { }

  getCompany(): Observable<Company>{
    return this.http.get<Company>(this.accessPointUrl)
  }

  getCompanyByID(id): Observable<Company>{
    return this.http.get<Company>(this.accessPointUrl + '/' + id)
  }

  postCompany(company: Company): Observable<Company>{
    return this.http.post<Company>(this.accessPointUrl, company)
  }    
}
