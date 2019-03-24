using Elesche.Models.SchoolModel;
using Elesche.Models.TeacherModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.ViewModels
{
    public class TeacherCreateViewModel
    {
        public int? SchoolId { get; set; }
        public SelectList Schools { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<SubjectSelectViewModel> Subjects { get; set; }
    }
}
