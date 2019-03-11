using Elesche.Models.SchoolModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models
{
    public class SeedData
    {
        /// <summary>
        /// Initializes datas into ApplicationDbContext database
        /// </summary>
        /// <param name="app"></param>
        public static void EnsurePopulated(IApplicationBuilder app)
        {

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
               if (!context.Schools.Any())
                {
                    context.Schools.AddRange(
                        new School() { Name = "ЗОШ1", Director = "Director1" },
                        new School() { Name = "ЗОШ2", Director = "Director2" },
                        new School() { Name = "ЗОШ3", Director = "Director3" },
                        new School() { Name = "ЗОШ4", Director = "Director4" },
                        new School() { Name = "ЗОШ5", Director = "Director5" },
                        new School() { Name = "ЗОШ6", Director = "Director6" },
                        new School() { Name = "ЗОШ7", Director = "Director7" },
                        new School() { Name = "ЗОШ8", Director = "Director8" }
                    );
                }
                context.SaveChanges();
            }

            
        }
    }
}
