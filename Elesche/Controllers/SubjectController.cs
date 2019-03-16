using Elesche.Models.Database;
using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using Elesche.Models.SubjectModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Elesche.ViewModels;
using Elesche.Models;

namespace Elesche.Controllers
{
    public class SubjectController:Controller
    {
        private IGenericRepository<Subject> subjectRepository;
        private IGenericRepository<Equipment> equipmentrepository;
        private IGenericRepository<School> schoolRepository;

        public SubjectController(IGenericRepository<Subject> subjectRepository,IGenericRepository<Equipment> equipmentrepository,
            IGenericRepository<School> schoolRepository)
        {
            this.subjectRepository = subjectRepository;
            this.equipmentrepository = equipmentrepository;
            this.schoolRepository = schoolRepository;
        }
        public ViewResult List(int? id)
        {
            var all = subjectRepository.GetAll(s => s.School);
            if (id == null)
            {
                return View(all);

            }
            var subjects = all.Where(i => i.SchoolId == id);
            ViewBag.SchoolId = id;
            return View(subjects);
        }
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            var subjects = subjectRepository.GetSingle(i => i.Id == id,s=>s.School);
            if (subjects == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            return View(subjects);
        }
        [HttpGet]
        public ActionResult Create(int? id)
        {
            ViewBag.School = new SelectList(schoolRepository.Items, "Id", "Name",id);
            ViewBag.SchoolId = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(include: "Name,Class,Semester,HoursPerWeek,SchoolId")]Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    System.Diagnostics.Debug.WriteLine("\n\n\n\n SUBJECT ID: "+subject.SchoolId);
                    subjectRepository.Add(subject);
                    await subjectRepository.SaveAsync();
                    return RedirectToAction("List",new { id=subject.SchoolId});
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(subject);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            var item = subjectRepository.GetSingle(i => i.Id == id, s => s.School);
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
            var item = await subjectRepository.FindAsync(id);
            subjectRepository.Delete(item);
            await subjectRepository.SaveAsync();
            return RedirectToAction("List", new { id = item.SchoolId });
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            var item = subjectRepository.GetSingle(i => i.Id == id,e=>e.Equipment,s=>s.School);
            ViewBag.School = new SelectList(schoolRepository.Items, "Id", "Name",item.School.Id);
            if (item == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            var subjectEquipmentsViewModel = new SubjectEquipmentsViewModel
            {
                Subject=item,
                Equipments = equipmentrepository.Items.Where(s=>s.SchoolId==item.School.Id)
                .Select(o => new SelectListItem
                {
                    Text = o.Name,
                    Value = o.Id.ToString()
                })
            };
            return View(subjectEquipmentsViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SubjectEquipmentsViewModel subjectEquipmentsViewModel)
        {
            if (ModelState.IsValid)
            {
                var item = subjectRepository.GetSingle(i => i.Id == subjectEquipmentsViewModel.Subject.Id,e=>e.Equipment, s => s.School);

                if (equipmentrepository.Items.FirstOrDefault(i => i.Id == subjectEquipmentsViewModel.Subject.EquipmentId) == null)
                    subjectEquipmentsViewModel.Subject.EquipmentId = null;
                subjectRepository.Update(subjectEquipmentsViewModel.Subject);
                await subjectRepository.SaveAsync();
                return RedirectToAction("List", new { id=item.School.Id});
            }
            return View(subjectEquipmentsViewModel.Subject);
        }
    }
}
