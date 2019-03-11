using Elesche.Models.SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models
{
    public interface ISchoolRepository:ICRUD<School>
    {
        /// <summary>
        /// The repository of schools
        /// </summary>
        IEnumerable<School> Schools { get; }
        Task SaveAsync();


    }
}
