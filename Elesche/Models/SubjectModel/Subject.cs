using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using System;
using System.Collections.Generic;
namespace Elesche.Models.SubjectModel
{
    public class Subject
    {
        /// <summary>
        /// The equipment ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the Subject
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The enum of school year
        /// </summary>
        public SchoolYearOfHightSchool SchoolYearOfHightSchool { get; set; }
        /// <summary>
        /// How much time is needed for the subject
        /// </summary>
        public int HoursPerWeek { get; set; }
        /// <summary>
        /// The equipments that are needed for subject
        /// </summary>
        public List<Equipment> Equipments { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}

