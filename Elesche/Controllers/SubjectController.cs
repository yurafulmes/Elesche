using Elesche.Models.Database;
using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using Elesche.Models.SubjectModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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
            return View(subjects);
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
           Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    subjectRepository.Add(subject);
                    await subjectRepository.SaveAsync();
                    return RedirectToAction("List");
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
    }
}
