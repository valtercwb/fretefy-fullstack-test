using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
  public class RegiaoCidadeMap : IEntityTypeConfiguration<RegiaoCidade>
  {
    public void Configure(EntityTypeBuilder<RegiaoCidade> builder)
    {
      builder.HasKey(p => p.Id);
    }
  }
}