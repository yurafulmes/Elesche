using Elesche.Models.EquipmentModel;
using System;
using System.Collections.Generic;
namespace Elesche.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public int Semester { get; set; }
        public int HoursPerWeek { get; set; }
        public List<Equipment> Equipments { get; set; }
    }
}

