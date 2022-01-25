using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
  public interface IRegiaoService
  {
    object Get(Guid id);
    IEnumerable<Regiao> List();
    object Post(Regiao regiao);
    object Put(Regiao regiao);
  }
}
