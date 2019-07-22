using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.Repository.EntityFrameworkCore;
using SwiftHorse.TestKit.Infrastructure;
using SwiftHorse.TestKit.WebApi.Filters;

namespace SwiftHorse.TestKit.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);

            services.AddRepository<TestKitDbContext>((builder) =>
            {
                builder.UseMySql(Configuration.GetConnectionString("MySql"));
            });
            services.AddScoped<UnitOfWorkFilter>();

            services.AddMvc((options) =>
            {
                options.Filters.Add<UnitOfWorkAttribute>();
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "My API", Version = "v1" });
            });

            services.AddTestKit((builder) =>
            {
                builder.UseLocalRunner();
                builder.UseInfrastructure();
                builder.UseQuery();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
