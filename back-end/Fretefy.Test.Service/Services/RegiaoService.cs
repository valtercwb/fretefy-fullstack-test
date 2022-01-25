using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Enum;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.Service.Services
{
  public class RegiaoService : IRegiaoService
  {
    private readonly IRegiaoRepository _regiaoRepository;

    public RegiaoService(IRegiaoRepository regiaoRepository)
    {
      _regiaoRepository = regiaoRepository;
    }

    public object Get(Guid id)
    {
      return _regiaoRepository.GetById(id);
    }

    public IEnumerable<Regiao> List()
    {
      return _regiaoRepository.List();
    }

    public object Post(Regiao regiao)
    {
      regiao.Status = StatusRegiao.Ativo;
      regiao.Id = Guid.NewGuid();
      return _regiaoRepository.Post(regiao);
    }

    public object Put(Regiao regiao)
    {
      return _regiaoRepository.Put(regiao);
    }
  }
}
