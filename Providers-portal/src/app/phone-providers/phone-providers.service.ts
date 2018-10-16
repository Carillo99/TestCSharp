import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

import { PhoneProviders } from './phone-providers.model';
import { INCOMETAX_API } from '../app.api';

@Injectable({
  providedIn: 'root'
})
export class PhoneProvidersService {

  private accessPointUrl: string = INCOMETAX_API + '/v1/company-providers/';

  constructor(private http: HttpClient) { }

  postPhone(phoneProviders: PhoneProviders, companyProvidersId): Observable<PhoneProviders>{
  	return this.http.post<PhoneProviders>(this.accessPointUrl + companyProvidersId + '/phone-providers', phoneProviders)
  }	  
}