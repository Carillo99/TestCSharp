import { CompanyProviders } from '../company-providers/company-providers.model';
import { UF } from '../enum/uf.enum';

export class Company {
  id: number;
  fantasyName: string;
  cnpj: string;
  uf: UF;
  companyproviders: CompanyProviders;
}
