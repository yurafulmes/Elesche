using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Elesche.Models
{
    public class ApplicationDbContext:DbContext
    {
        /// <summary>
        /// School table
        /// </summary>
        public DbSet<School> Schools { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

    }
}
