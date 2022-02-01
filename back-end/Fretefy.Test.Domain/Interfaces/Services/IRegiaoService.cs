using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
  public interface IRegiaoService
  {
    object Get(int id);
    IEnumerable<Regiao> List();
    Resposta Inserir(Regiao regiao);
    Resposta Atualizar(Regiao regiao);
  }
}
