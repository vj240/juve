using System.Web.Mvc;
using Juve.Data.Abstractions;
using Juve.Data.Concrete;
using Juve.Model;
using JuveApp.Core;

namespace JuveApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CountryController : BaseController
    {
        private readonly ICountryRepository _repository;

        public CountryController()
        {
            _repository = new CountryRepository(Db);
        }

        public ActionResult Index()
        {
            return View(_repository.DbSet);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _repository.AddItem(country);
                return RedirectToAction("Index");
            }

            return View(country);
        }

        public ActionResult Edit(int id = 0)
        {
            var country = _repository.Single(c => c.Id == id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        [HttpPost]
        public ActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateItem(country);
                return RedirectToAction("Index");
            }
            return View(country);
        }


        public ActionResult Delete(int id = 0)
        {
            var country = _repository.Single(c => c.Id == id);
            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var country = _repository.Single(c => c.Id == id);
            _repository.DeleteItem(country);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id = 0)
        {
            var country = _repository.Single(c => c.Id == id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }
    }
}
