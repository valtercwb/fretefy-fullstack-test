import { TipoStatus } from "../shared/tipo-status.enum";

export class Regiao {
  id: number;
  nome: string;
  status: TipoStatus;
  regiaoCidades: [];
}