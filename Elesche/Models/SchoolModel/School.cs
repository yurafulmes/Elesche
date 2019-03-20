using Elesche.Models.EquipmentModel;
using Elesche.Models.SubjectModel;
using Elesche.Models.TeacherModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models.SchoolModel
{
    public class School
    {
        /// <summary>
        /// The school ID 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the school
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The name of the director
        /// </summary>
        public string Director { get; set; }
        public virtual IEnumerable<Equipment> Equipments { get; set; }
        public virtual IEnumerable<Subject> Subjects { get; set; }
        public virtual IEnumerable<Teacher> Teachers { get; set; }
    }
}
