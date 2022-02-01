using Fretefy.Test.Domain.Entities;
using System;
using System.Linq;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
  public interface IRegiaoRepository
  {
    IQueryable<Regiao> List();
    bool Post(Regiao regiao);
    Regiao GetById(int id);
    bool Atualizar(Regiao regiao);
    bool VerificaNomeJaExiste(string nome);
  }
}
