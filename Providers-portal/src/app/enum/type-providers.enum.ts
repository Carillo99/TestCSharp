export enum TypeProviders{
  CPF = 1,
  CNPJ = 2
}

export namespace TypeProviders {

  export function values() {
    return Object.keys(TypeProviders).filter(
      (type) => isNaN(<any>type) && type !== 'values'
    );
  }
}