using Elesche.Models;
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
    public class EquipmentController:Controller
    {
        private IGenericRepository<Equipment> repository;
        private IGenericRepository<School> repositorySchool;
        private IGenericRepository<Subject> subjectRepository;
        public EquipmentController(IGenericRepository<Equipment> repository, IGenericRepository<School> repositorySchool,
            IGenericRepository<Subject> subjectRepository)
        {
            this.repository = repository;
            this.repositorySchool = repositorySchool;
            this.subjectRepository = subjectRepository;

        }

        public ViewResult List(int? id)
        {
            var all = repository.GetAll(s => s.School);
            if (id == null)
            {
                return View(all);

            }
            var equipments =all.Where(i => i.SchoolId == id);
            ViewBag.SchoolId = id;
            System.Diagnostics.Debug.WriteLine(id);
            return View(equipments);
        }
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            var equipment = repository.GetSingle(i => i.Id == id, s => s.School);
            if (equipment == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            return View(equipment);
        }
        [HttpGet]
        public ActionResult Create(int? id)
        {
            ViewBag.School = new SelectList(repositorySchool.Items, "Id", "Name",id);
            ViewBag.SchoolId = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
           [Bind (include:"Name,SchoolId")]Equipment equipment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    System.Diagnostics.Debug.WriteLine(equipment.SchoolId);
                    repository.Add(equipment);
                    await repository.SaveAsync();
                    return RedirectToAction("List",new { id = equipment.SchoolId});
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(equipment);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            var item = repository.GetSingle(i => i.Id == id, s => s.School);
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
            var fkSetNull = repository.GetSingle(i => i.Id == id, s => s.Subjects);
            foreach (var fk in fkSetNull.Subjects)
            {
                fk.EquipmentId = null;
                subjectRepository.Update(fk);
            }
            repository.Delete(fkSetNull);
            await repository.SaveAsync();
            await subjectRepository.SaveAsync();
            return RedirectToAction("List",new { id= fkSetNull.SchoolId});
        }
    }
}
