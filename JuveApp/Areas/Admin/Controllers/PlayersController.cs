using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Juve.Model;
using JuveApp.Core;

namespace JuveApp.Areas.Admin.Controllers
{
    public class PlayersController : BaseController
    {
        public ActionResult Index()
        {
            var players = Db.Players.Include(p => p.PlayerType).Include(p => p.Team).Include(p => p.Country);
            return View(players.ToList());
        }

        //
        // GET: /Admin/Players/Details/5

        public ActionResult Details(int id = 0)
        {
            Player player = Db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        //
        // GET: /Admin/Players/Create

        public ActionResult Create()
        {
            ViewBag.PlayerTypeId = new SelectList(Db.PlayerTypes, "Id", "Name");
            ViewBag.TeamId = new SelectList(Db.Teams, "Id", "Name");
            ViewBag.CountryId = new SelectList(Db.Countries, "Id", "Name");
            return View();
        }

        //
        // POST: /Admin/Players/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                Db.Players.Add(player);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlayerTypeId = new SelectList(Db.PlayerTypes, "Id", "Name", player.PlayerTypeId);
            ViewBag.TeamId = new SelectList(Db.Teams, "Id", "Name", player.TeamId);
            ViewBag.CountryId = new SelectList(Db.Countries, "Id", "Name", player.CountryId);
            return View(player);
        }

        //
        // GET: /Admin/Players/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Player player = Db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlayerTypeId = new SelectList(Db.PlayerTypes, "Id", "Name", player.PlayerTypeId);
            ViewBag.TeamId = new SelectList(Db.Teams, "Id", "Name", player.TeamId);
            ViewBag.CountryId = new SelectList(Db.Countries, "Id", "Name", player.CountryId);
            return View(player);
        }

        //
        // POST: /Admin/Players/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                Db.Entry(player).State = EntityState.Modified;
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlayerTypeId = new SelectList(Db.PlayerTypes, "Id", "Name", player.PlayerTypeId);
            ViewBag.TeamId = new SelectList(Db.Teams, "Id", "Name", player.TeamId);
            ViewBag.CountryId = new SelectList(Db.Countries, "Id", "Name", player.CountryId);
            return View(player);
        }

        //
        // GET: /Admin/Players/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Player player = Db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        //
        // POST: /Admin/Players/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = Db.Players.Find(id);
            Db.Players.Remove(player);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}