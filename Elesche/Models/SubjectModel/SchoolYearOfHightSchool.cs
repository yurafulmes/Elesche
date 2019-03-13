using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models.SubjectModel
{
    [ComplexType]
    public class SchoolYearOfHightSchool
    {
        /// <summary>
        /// The n-th class
        /// </summary>
        public int Class { get;set; }
        /// <summary>
        /// The enum of semester
        /// </summary>
        public Semester Semester { get; set; }
    }
}
