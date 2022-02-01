using System;

namespace Fretefy.Test.Domain.Entities
{
  public class Cidade : IEntity
  {
    public Cidade()
    {

    }

    public Cidade(int id, string nome, string uf)
    {
      Id = id;
      Nome = nome;
      UF = uf;
    }

    public long Id { get; set; }

    public string Nome { get; set; }

    public string UF { get; set; }

  }
}
