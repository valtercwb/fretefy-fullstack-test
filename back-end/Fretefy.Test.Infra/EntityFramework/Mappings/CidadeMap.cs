using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
  public class CidadeMap : IEntityTypeConfiguration<Cidade>
  {
    public void Configure(EntityTypeBuilder<Cidade> builder)
    {
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Nome).HasMaxLength(1024).IsRequired();
      builder.Property(p => p.UF).HasMaxLength(2).IsRequired();

      builder.HasData(
          new Cidade(1, "Rio Branco", "AC"),
          new Cidade(2, "Maceió", "AL"),
          new Cidade(3, "Macapá", "AP"),
          new Cidade(4, "Manaus", "AM"),
          new Cidade(5, "Salvador", "BA"),
          new Cidade(6, "Fortaleza", " CE"),
          new Cidade(7, "Brasília", "DF"),
          new Cidade(8, "Vitória", "ES"),
          new Cidade(9, "Goiânia", "GO"),
          new Cidade(10,"São Luís", "MA"),
          new Cidade(11, "Cuiabá", "MT"),
          new Cidade(12, "Campo Grande", "MS"),
          new Cidade(13, "Belo Horizonte", "MG"),
          new Cidade(14, "Belém", "PA"),
          new Cidade(15, "João Pessoa", "PB"),
          new Cidade(16, "Curitiba", "PR"),
          new Cidade(17, "Recife", "PE"),
          new Cidade(18, "Teresina", "PI"),
          new Cidade(19, "Rio de Janeiro", "RJ"),
          new Cidade(20, "Natal", "RN"),
          new Cidade(21, "Porto Alegre", "RS"),
          new Cidade(22, "Porto Velho", "RO"),
          new Cidade(23, "Boa Vista", "RR"),
          new Cidade(24, "Florianópolis", "SC"),
          new Cidade(25, "São Paulo", "SP"),
          new Cidade(26, "Aracaju", "SE"),
          new Cidade(27, "Palmas", "TO") 
      );
    }
  }
}
