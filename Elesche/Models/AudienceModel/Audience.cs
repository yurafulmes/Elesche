
using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using System;
using System.Collections.Generic;

namespace Elesche.Models.AudienceModel
{
    public class Audience
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public uint NumberOfClasses { get; set; }
        public virtual School School { get; set; }
        public virtual Equipment Equipment { get; set; }

    }
}
