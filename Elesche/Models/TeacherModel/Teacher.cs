using Elesche.Models.Database;
using Elesche.Models.SchoolModel;
using Elesche.Models.SubjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elesche.Models.TeacherModel
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
        public virtual List<TeacherSubject> TeacherSubjects { get; set; }
    }
}
