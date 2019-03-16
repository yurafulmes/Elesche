using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        /// The n-th class
        /// </summary>
        public int Class { get; set; }
        /// <summary>
        /// The enum of semester
        /// </summary>
        public int Semester { get; set; }
        /// <summary>
        /// How much time is needed for the subject
        /// </summary>
        public int HoursPerWeek { get; set; }
        /// <summary>
        /// The equipments that are needed for subject
        /// </summary>
        public virtual Equipment Equipment{ get; set; }
        public int? EquipmentId { get; set; }
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}

