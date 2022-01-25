using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
  public class RegiaoRepository : IRegiaoRepository
  {
    private readonly DbContext _contexto;

    public RegiaoRepository(DbContext dbContext)
    {
      _contexto = dbContext;
    }

    public Regiao GetById(Guid id)
    {
      return _contexto.Set<Regiao>().Include(x => x.RegiaoCidades)
                                    .ThenInclude(y => y.Cidade).AsQueryable()
                                    .Where(x => x.Id == id).FirstOrDefault();
    }

    public IQueryable<Regiao> List()
    {
      return _contexto.Set<Regiao>().Include(x => x.RegiaoCidades)
                                    .ThenInclude(y => y.Cidade)
                                    .AsQueryable().AsNoTracking();
    }

    public bool Post(Regiao regiao)
    {
      _contexto.Set<Regiao>().Add(regiao);
      _contexto.SaveChanges();
      return true;
    }

    public bool Put(Regiao regiao)
    {
      var regiaoBase = _contexto.Set<Regiao>().Where(x => x.Id == regiao.Id).FirstOrDefault();

      if (regiaoBase != null)
        return false;

      regiaoBase.Nome = regiao.Nome;
      regiaoBase.Status = regiao.Status;
      regiaoBase.RegiaoCidades = regiao.RegiaoCidades;

      _contexto.SaveChanges();
      return true;
    }
  }
}
