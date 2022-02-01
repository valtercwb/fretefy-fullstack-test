using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fretefy.Test.Domain.Entities
{
  public class RegiaoCidade : IEntity
  {
    public long Id { get; set; }

    [ForeignKey("Regiao")]
    public long RegiaoId { get; set; }

    [ForeignKey("Cidade")]

    public long CidadeId { get; set; }
    public virtual Cidade Cidade { get; set; }

  }
}
