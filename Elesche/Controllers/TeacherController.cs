using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Elesche.Models.Database;
using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using Elesche.Models.SubjectModel;
using Elesche.Models.TeacherModel;
using Elesche.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elesche.Controllers
{
    public class TeacherController : Controller
    {
        private IGenericRepository<Teacher> teacherRepository;
        private IGenericRepository<TeacherSubject> TeacherSubjectRepository;
        private IGenericRepository<School> schoolRepository;
        private IGenericRepository<Subject> subjectRepository;
        public TeacherController(IGenericRepository<Teacher> teacherRepository, IGenericRepository<TeacherSubject> TeacherSubjectRepository,
            IGenericRepository<School> schoolRepository, IGenericRepository<Subject> subjectRepository)
        {
            this.teacherRepository = teacherRepository;
            this.TeacherSubjectRepository = TeacherSubjectRepository;
            this.schoolRepository = schoolRepository;
            this.subjectRepository = subjectRepository;
        }
        public ViewResult List(int? id)
        {
            var all = teacherRepository.GetAll(s => s.TeacherSubjects,sc=>sc.School);
            if (id == null)
            {
                return View(all);

            }
            var teachers = all.Where(i => i.SchoolId == id);
            ViewBag.SchoolId = id;
            return View(teachers);
        }
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            var teachers = teacherRepository.GetSingle(i => i.Id == id, s => s.School,su=>su.TeacherSubjects);
            if (teachers == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            return View(teachers);
        }
        [HttpGet]
        public ActionResult Create(int? id)
        {
            var viewModel = new TeacherCreateViewModel
            {
                Subjects = subjectRepository.Items
                    .Select(s => new SubjectSelectViewModel
                    {
                        Subject = s,
                        IsSelected = false
                    })
                    .ToList(),
                SchoolId=id,
                Schools= new SelectList(schoolRepository.Items, "Id", "Name", id)
            };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            TeacherCreateViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    teacherRepository.Add(viewModel.Teacher);
                    await teacherRepository.SaveAsync();

                    foreach (var selectedSubject
                        in viewModel.Subjects.Where(c => c.IsSelected))
                    {
                        var teacherSubject = new TeacherSubject
                        {
                            SubjectId = selectedSubject.Subject.Id,
                            TeacherId = viewModel.Teacher.Id
                        };

                        TeacherSubjectRepository.Add(teacherSubject);
                        await TeacherSubjectRepository.SaveAsync();
                    }
                    return RedirectToAction("List", new { id = viewModel.SchoolId });
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(viewModel);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            var item = teacherRepository.GetSingle(i => i.Id == id, s => s.School);
            if (item == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var fkDelete = teacherRepository.GetSingle(i => i.Id == id, ts => ts.TeacherSubjects);
            foreach (var fk in fkDelete.TeacherSubjects)
            {
                TeacherSubjectRepository.Delete(fk.Id);
            }
            await TeacherSubjectRepository.SaveAsync();
            teacherRepository.Delete(fkDelete.Id);
            await teacherRepository.SaveAsync();
            return RedirectToAction("List", new { id = fkDelete.SchoolId });
        }

    }
}