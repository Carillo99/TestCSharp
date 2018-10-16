import { CompanyProviders } from '../company-providers/company-providers.model';

export class PhoneProviders {
  id: number;
  phone: string;
  companyProvidersId: number;
  companyProviders: CompanyProviders;
}