using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Juve.Model;
using Juve.Data;

namespace JuveApp.Controllers
{
    public class TestController : Controller
    {
        private JuveContext db = new JuveContext();

        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View(db.PlayerTypes.ToList());
        }

        //
        // GET: /Test/Details/5

        public ActionResult Details(int id = 0)
        {
            PlayerType playertype = db.PlayerTypes.Find(id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        //
        // GET: /Test/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Test/Create

        [HttpPost]
        public ActionResult Create(PlayerType playertype)
        {
            if (ModelState.IsValid)
            {
                db.PlayerTypes.Add(playertype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(playertype);
        }

        //
        // GET: /Test/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PlayerType playertype = db.PlayerTypes.Find(id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        //
        // POST: /Test/Edit/5

        [HttpPost]
        public ActionResult Edit(PlayerType playertype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playertype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(playertype);
        }

        //
        // GET: /Test/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PlayerType playertype = db.PlayerTypes.Find(id);
            if (playertype == null)
            {
                return HttpNotFound();
            }
            return View(playertype);
        }

        //
        // POST: /Test/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerType playertype = db.PlayerTypes.Find(id);
            db.PlayerTypes.Remove(playertype);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}