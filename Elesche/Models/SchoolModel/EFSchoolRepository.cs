using Elesche.Models.SchoolModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models
{
    public class EFSchoolRepository:ISchoolRepository
    {
        /// <summary>
        /// Object of database context
        /// </summary>
        private ApplicationDbContext context;

        public EFSchoolRepository(ApplicationDbContext context)
        {
            this.context = context;
            
        }
        public IEnumerable<School> Schools => context.Schools;
        public void Add(School school)
        {
            context.Schools.Add(school);
        }
        public void Update(School school)
        {
            context.Entry(school).State = EntityState.Modified;
        }
        public void Delete(School school)
        {
            context.Schools.Remove(school);
        }
        public School Get(int id)
        {
            return context.Schools.FirstOrDefault(school => school.Id == id);
        }
        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
        public async Task<School> FindAsync(int? ID)
        {
            return await context.Schools.FindAsync(ID);
        }
    }
}
