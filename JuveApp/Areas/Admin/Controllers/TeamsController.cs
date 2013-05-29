using System.Data;
using System.Linq;
using System.Web.Mvc;
using Juve.Data.Abstractions;
using Juve.Data.Concrete;
using Juve.Model;
using JuveApp.Core;

namespace JuveApp.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Authorize(Users = "vj")]
    public class TeamsController : BaseController
    {
        private readonly ITeamsRepository _repository;

        public TeamsController()
        {
            _repository = new TeamsRepository(Db);
        }

        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public ActionResult Details(int id = 0)
        {
            var team = _repository.Single(t => t.Id == id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        public ActionResult Create()
        {
            ViewBag.Countries = Db.Countries.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Team team)
        {
            if (ModelState.IsValid)
            {
                _repository.AddItem(team);
                return RedirectToAction("Index");
            }
            ViewBag.Countries = Db.Countries.ToList();
            return View(team);
        }

        public ActionResult Edit(int id = 0)
        {
            var team = _repository.Single(t => t.Id == id);
            if (team == null)
            {
                return HttpNotFound();
            }

            ViewBag.Countries = Db.Countries.ToList();
            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Team team)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateItem(team);
                return RedirectToAction("Index");
            }
            return View(team);
        }

        public ActionResult Delete(int id = 0)
        {
            var team = _repository.Single(t => t.Id == id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var team = _repository.Single(t => t.Id == id);
            _repository.DeleteItem(team);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}