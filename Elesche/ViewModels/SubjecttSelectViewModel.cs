using Elesche.Models.EquipmentModel;
using Elesche.Models.SubjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.ViewModels
{
    public class SubjectSelectViewModel
    {
        public Subject Subject { get; set; }
        public bool IsSelected { get; set; }
    }
}
