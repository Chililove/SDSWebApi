using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SDS.Core.Application_Service;
using SDS.Core.Application_Service.Service;
using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using SDS.Infrastructure.Data;
using SDS.Infrastructure.Data.Repositories;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAvatarRepository, AvatarRepo>();
            services.AddScoped<IAvatarService, AvatarService>();
            services.AddScoped<IOwnerRepository, OwnerRepo>();
            services.AddScoped<IOwnerService, OwnerService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var repo = scope.ServiceProvider.GetRequiredService<IAvatarRepository>();
                var orepo = scope.ServiceProvider.GetRequiredService<IOwnerRepository>();

                /* repo.Create(new Avatar { Name = "Chili", Type = "Magician", Color = "Pink" });
                 repo.Create(new Avatar { Name = "Bunsy", Type = "Healer", Color = "Black" });*/

                IAvatarRepository aRepo = new AvatarRepo();
                IOwnerRepository owRepo = new OwnerRepo();

                DBInit db = new DBInit(aRepo, owRepo);
                db.InitData(); // Mock data
                IAvatarService aService = new AvatarService(aRepo);
                IOwnerService owService = new OwnerService(owRepo);

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
        }
    }
}
