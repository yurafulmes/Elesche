using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Elesche.Models;
using Elesche.Models.Database;
using Elesche.Models.EquipmentModel;
using Elesche.Models.SchoolModel;
using Microsoft.AspNetCore.Mvc;

namespace Elesche.Controllers
{
    public class SchoolController : Controller
    {
        /// <summary>
        /// The object of school repository
        /// </summary>
        private IGenericRepository<School> repository;
        private IGenericRepository<Equipment> repositoryEquipment;
        public SchoolController(IGenericRepository<School> repository, IGenericRepository<Equipment> repositoryEquipment)
        {
            this.repository = repository;
            this.repositoryEquipment = repositoryEquipment;


        }
        public ViewResult List() => View(repository.Items);
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            School school = repository.GetSingle(i => i.Id==id,e=>e.Equipments,s=>s.Subjects);
            if (school == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            return View(school);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
           [Bind(include: "Name,Director")]School student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repository.Add(student);
                    await repository.SaveAsync();
                    return RedirectToAction("List");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(student);
        }
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            School school = await repository.FindAsync(id);
            if (school == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            return View(school);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(include :  "Id,Name,Director")] School school)
        {
            if (ModelState.IsValid)
            {
                repository.Update(school);
                await repository.SaveAsync();
                return RedirectToAction("List");
            }
            return View(school);
        }
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View(HttpStatusCode.BadRequest);
            }
            School school = await repository.FindAsync(id);
            if (school == null)
            {
                return View(HttpStatusCode.NotFound);
            }
            return View(school);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            School school = await repository.FindAsync(id);
            repository.Delete(school);
            await repository.SaveAsync();
            return RedirectToAction("List");
        }
    }
}