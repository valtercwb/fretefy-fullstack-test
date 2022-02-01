using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Infra.EntityFramework.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Fretefy.Test.Infra.EntityFramework
{
  public class TestDbContext : DbContext
  {
    private readonly ILoggerFactory _loggerFactory;

    public DbSet<Regiao> Regiao { get; set; }
    public DbSet<RegiaoCidade> RegiaoCidade { get; set; }
    public DbSet<Cidade> Cidade { get; set; }

    public TestDbContext()
    {

    }

    public TestDbContext(DbContextOptions<TestDbContext> options, ILoggerFactory loggerFactory)
        : base(options)
    {
      _loggerFactory = loggerFactory;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLoggerFactory(_loggerFactory)
      .EnableSensitiveDataLogging();
      optionsBuilder.EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.ApplyConfiguration(new CidadeMap());

      modelBuilder.ApplyConfiguration(new RegiaoCidadeMap());

      modelBuilder.ApplyConfiguration(new RegiaoMap());
    }
  }
}
