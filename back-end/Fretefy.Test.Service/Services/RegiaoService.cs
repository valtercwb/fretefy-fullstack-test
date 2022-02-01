using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Enum;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Domain.Util;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.Service.Services
{
  public class RegiaoService : IRegiaoService
  {
    private readonly IRegiaoRepository _regiaoRepository;
    private readonly IRegiaoCidadeRepository _regiaoCidadeRepository;

    public RegiaoService(IRegiaoRepository regiaoRepository, IRegiaoCidadeRepository regiaoCidadeRepository)
    {
      _regiaoRepository = regiaoRepository;
      _regiaoCidadeRepository = regiaoCidadeRepository;
    }

    public object Get(int id)
    {
      return _regiaoRepository.GetById(id);
    }

    public IEnumerable<Regiao> List()
    {
      return _regiaoRepository.List();
    }

    public Resposta Inserir(Regiao regiao)
    {
      bool nomeJaExiste = _regiaoRepository.VerificaNomeJaExiste(regiao.Nome);

      if (nomeJaExiste)
      {
        return new Resposta(false, "Já existe uma região com esse nome");
      }

      try
      {
        regiao.Status = StatusRegiao.Ativo;

        _regiaoRepository.Post(regiao);

        return new Resposta(true, string.Empty);
      }
      catch (Exception)
      {

      }

      return new Resposta(true, "Não foi possível concluir a operação");
    }

    public Resposta Atualizar(Regiao regiao)
    {
      try
      {
        _regiaoRepository.Atualizar(regiao);

        _regiaoCidadeRepository.Atualizar(regiao.RegiaoCidades);

        return new Resposta(true, string.Empty);
      }
      catch (Exception)
      {
      }

      return new Resposta(true, string.Empty);
    }
  }
}