using System.Collections.Generic;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
  public interface IRegiaoCidadeRepository
  {
    void Atualizar(IEnumerable<Entities.RegiaoCidade> regiaoCidades);
  }
}
