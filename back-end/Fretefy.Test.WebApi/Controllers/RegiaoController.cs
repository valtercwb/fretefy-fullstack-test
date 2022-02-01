using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.Controllers
{
  [Route("api/regiao")]
  [ApiController]
  public class RegiaoController : ControllerBase
  {
    private readonly IRegiaoService _regiaoService;

    public RegiaoController(IRegiaoService regiaoService)
    {
      _regiaoService = regiaoService;
    }

    [HttpGet]
    public IActionResult List()
    {
      IEnumerable<Regiao> listaRegiao = _regiaoService.List();

      return Ok(listaRegiao);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      if (id == default)
        return BadRequest();

      var resultado = _regiaoService.Get(id);

      if (resultado == null)
        return NotFound();

      return Ok(resultado);
    }

    [HttpPost]
    public IActionResult Post(Regiao regiao)
    {
      if (regiao == null)
        return BadRequest();

      var resultado = _regiaoService.Inserir(regiao);

      if (resultado == null)
        return BadRequest();

      return Ok(resultado);
    }

    [HttpPut]
    public IActionResult Put(Regiao regiao)
    {
      if (regiao == null || regiao.Id == default)
        return BadRequest();

      var resultado = _regiaoService.Atualizar(regiao);

      if (resultado == null)
        return BadRequest();

      return Ok(resultado);
    }

  }
}
