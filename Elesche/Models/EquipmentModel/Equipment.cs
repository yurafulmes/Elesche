using System.Collections.Generic;
using System;
using Elesche.Models.SchoolModel;
using Elesche.Models.SubjectModel;

namespace Elesche.Models.EquipmentModel
{
    public class Equipment
    {
        /// <summary>
        /// The equipment ID
        /// </summary>
        
        public int Id { get; set; }
        /// <summary>
        /// The name of the equipment
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// FK-School ID
        /// </summary>
        public int SchoolId { get; set; }
        /// <summary>
        /// School object
        /// </summary>
        public virtual School School { get; set; }
        public virtual IEnumerable<Subject> Subjects { get; set; }
    }
}