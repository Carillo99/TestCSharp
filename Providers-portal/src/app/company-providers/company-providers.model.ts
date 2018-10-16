import { Company } from '../company/company.model';
import { PhoneProviders } from '../phone-providers/phone-providers.model';

export class CompanyProviders {
  id: number;
  name: string;
  cpF_CNPJ: string;
  ativo: boolean;
  companyId: number;
  dateBirth: Date;
  rg: string;
  age: number;
  company: Company;
  phoneProviders: PhoneProviders;
}