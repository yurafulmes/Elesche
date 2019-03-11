using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Elesche.Models;
using Elesche.Models.EquipmentModel;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Elesche.Models.Database;
using Elesche.Models.SchoolModel;

namespace Elesche
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        IConfiguration Configuration;
        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                Configuration["Data:ElescheSchool:ConnectionString"]));
            services.AddScoped<IGenericRepository<School>, GenericRepository<School>>();
            services.AddScoped<IGenericRepository<Equipment>, GenericRepository<Equipment>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=School}/{action=Create}"
                    );
                routes.MapRoute(
                    name: "CreateSchool",
                    template: "{controller=School}/{action=Create}"
                    );
                    routes.MapRoute(
                    name: "pagination",
                    template: "Equipments/Equipment{id}",
                    defaults: new {Controller="Equipment", action="List"}
                    );
                routes.MapRoute(
                    name: "listEquipment",
                    template: "{controller=Equipment}/{action=List}/{id?}"
                    );
            });
            
                    

        }
    }
}
