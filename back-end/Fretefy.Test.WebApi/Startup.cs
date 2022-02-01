using Castle.Core.Logging;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Infra.EntityFramework;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Fretefy.Test.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;

namespace Fretefy.Test.WebApi
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddScoped<DbContext, TestDbContext>();
      services.AddDbContext<TestDbContext>((provider, options) =>
      {
        options.UseSqlite("Data Source=Data\\Test.db;");
      });

      ConfigureInfraService(services);
      ConfigureDomainService(services);

      services.AddMvc()
          .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
    }

    private void ConfigureDomainService(IServiceCollection services)
    {
      services.AddScoped<ICidadeService, CidadeService>();
      services.AddScoped<IRegiaoService, RegiaoService>();
    }

    private void ConfigureInfraService(IServiceCollection services)
    {
      services.AddScoped<ICidadeRepository, CidadeRepository>();
      services.AddScoped<IRegiaoRepository, RegiaoRepository>();
      services.AddScoped<IRegiaoCidadeRepository, RegiaoCidadeRepository>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());
      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
