using Fretefy.Test.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fretefy.Test.Domain.Entities
{
  public class Regiao : IEntity
  {
    public long Id { get; set; }

    public string Nome { get; set; }

    public StatusRegiao Status { get; set; }

    public virtual IEnumerable<RegiaoCidade> RegiaoCidades { get; set; }
  }
}
