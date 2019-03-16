using Elesche.Models;
using Elesche.Models.SubjectModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.ViewModels
{
    public class SubjectEquipmentsViewModel
    {
        public Subject Subject { get; set; }
        public IEnumerable<SelectListItem> Equipments { get; set; }

    }
}
