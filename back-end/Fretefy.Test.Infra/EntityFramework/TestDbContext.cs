using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Infra.EntityFramework.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Fretefy.Test.Infra.EntityFramework
{
  public class TestDbContext : DbContext
  {
    public DbSet<Regiao> Regiao { get; set; }
    public DbSet<RegiaoCidade> RegiaoCidade { get; set; }
    public DbSet<Cidade> Cidade { get; set; }

    public TestDbContext()
    {

    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.EnableSensitiveDataLogging();
      optionsBuilder.EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      modelBuilder.ApplyConfiguration(new CidadeMap());

      modelBuilder.ApplyConfiguration(new RegiaoCidadeMap());

      modelBuilder.ApplyConfiguration(new RegiaoMap());
    }
  }
}
