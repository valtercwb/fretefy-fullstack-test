using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
  public class RegiaoCidadeRepository : IRegiaoCidadeRepository
  {
    private readonly DbContext _contexto;

    public RegiaoCidadeRepository(DbContext dbContext)
    {
      _contexto = dbContext;
    }

    public void Atualizar(IEnumerable<RegiaoCidade> regiaoCidades)
    {
      var regiaoCidadeBase = _contexto.Set<RegiaoCidade>().Where(x => x.RegiaoId == regiaoCidades.FirstOrDefault().RegiaoId).ToArray();

      if (regiaoCidadeBase.Any())
      {
        _contexto.Set<RegiaoCidade>().RemoveRange(regiaoCidadeBase);
      }

      _contexto.Set<RegiaoCidade>().AddRange(regiaoCidades);

      _contexto.SaveChanges();
    }
  }
}
