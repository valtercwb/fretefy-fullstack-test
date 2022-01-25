using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fretefy.Test.Domain.Entities
{
  public class RegiaoCidade : IEntity
  {
    public Guid Id { get; set; }

    [ForeignKey("Regiao")]
    public Guid RegiaoId { get; set; }

    [ForeignKey("Cidade")]

    public Guid CidadeId { get; set; }
    public virtual Cidade Cidade { get; set; }

  }
}
