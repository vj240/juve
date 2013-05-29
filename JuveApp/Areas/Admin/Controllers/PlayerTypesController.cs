using System.Web.Mvc;
using Juve.Data.Concrete;
using Juve.Model;
using Juve.Data;
using Juve.Data.Abstractions;
using JuveApp.Core;

namespace JuveApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PlayerTypesController : BaseController
    {
        private readonly IPlayerTypesRepository _repository;

        public PlayerTypesController()
        {
            _repository = new PlayerTypesRepository(Db);
        }

        public ActionResult Index()
        {
            return View(_repository.DbSet);
        }

        public ActionResult Details(int id = 0)
        {
            PlayerType playertype = _repository.Single(type => type.Id == id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PlayerType playertype)
        {
            if (ModelState.IsValid)
            {
                _repository.AddItem(playertype);
                return RedirectToAction("Index");
            }

            return View(playertype);
        }

        public ActionResult Edit(int id = 0)
        {
            PlayerType playertype = _repository.Single(type => type.Id == id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        [HttpPost]
        public ActionResult Edit(PlayerType playertype)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateItem(playertype);
                return RedirectToAction("Index");
            }
            return View(playertype);
        }

        public ActionResult Delete(int id = 0)
        {
            PlayerType playertype = _repository.Single(type => type.Id == id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerType playertype = _repository.Single(type=> type.Id == id);
            _repository.DeleteItem(playertype);
            return RedirectToAction("Index");
        }

    }
}