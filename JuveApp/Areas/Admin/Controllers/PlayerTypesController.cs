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
        private readonly JuveContext _db;
        private readonly IPlayerTypesRepository _repository;

        public PlayerTypesController()
        {
            _db = new JuveContext();
            _repository = new PlayerTypesRepository(_db);
        }

        //
        // GET: /Admin/PlayerTypes/

        public ActionResult Index()
        {
            return View(_repository.DbSet);
        }

        //
        // GET: /Admin/PlayerTypes/Details/5

        public ActionResult Details(int id = 0)
        {
            PlayerType playertype = _repository.Single(type => type.Id == id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        //
        // GET: /Admin/PlayerTypes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/PlayerTypes/Create

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

        //
        // GET: /Admin/PlayerTypes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PlayerType playertype = _repository.Single(type => type.Id == id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        //
        // POST: /Admin/PlayerTypes/Edit/5

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

        //
        // GET: /Admin/PlayerTypes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PlayerType playertype = _repository.Single(type => type.Id == id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        //
        // POST: /Admin/PlayerTypes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerType playertype = _repository.Single(type=> type.Id == id);
            _repository.DeleteItem(playertype);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}