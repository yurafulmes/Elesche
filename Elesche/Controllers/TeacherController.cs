using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Elesche.Models.Database;
using Elesche.Models.SchoolModel;
using Elesche.Models.TeacherModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elesche.Controllers
{
    public class TeacherController : Controller
    {
        private IGenericRepository<Teacher> teacherRepository;
        private IGenericRepository<TeacherSubject> TeacherSubjectRepository;
        private IGenericRepository<School> schoolRepository;
        public TeacherController(IGenericRepository<Teacher> teacherRepository, IGenericRepository<TeacherSubject> TeacherSubjectRepository,
            IGenericRepository<School> schoolRepository)
        {
            this.teacherRepository = teacherRepository;
            this.TeacherSubjectRepository = TeacherSubjectRepository;
            this.schoolRepository = schoolRepository;
        }
        public ViewResult List(int? id)
        {
            var all = teacherRepository.GetAll(s => s.Subjects,sc=>sc.School);
            if (id == null)
            {
                return View(all);

            }
            var teachers = all.Where(i => i.SchoolId == id);
            ViewBag.SchoolId = id;
            return View(teachers);
        }
        [HttpGet]
        public ActionResult Create(int? id)
        {
            ViewBag.School = new SelectList(schoolRepository.Items, "Id", "Name", id);
            ViewBag.SchoolId = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(include: "FirstName,LastName,Patronymic,SchoolId")]Teacher subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    System.Diagnostics.Debug.WriteLine("\n\n\n\n SUBJECT ID: " + subject.SchoolId);
                    teacherRepository.Add(subject);
                    await teacherRepository.SaveAsync();
                    return RedirectToAction("List", new { id = subject.SchoolId });
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(subject);
        }
    }
}