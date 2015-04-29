using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using TallaghtTimetable.Models;

namespace TallaghtTimetable.Controllers
{
    public class IconsController : Controller
    {
        private RoomDBContext db = new RoomDBContext();

        // GET: Icons
        public async Task<ActionResult> Index()
        {
            return View(await db.Icons.ToListAsync());
        }

        // GET: Icons/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Icon icon = await db.Icons.FindAsync(id);
            if (icon == null)
            {
                return HttpNotFound();
            }
            return View(icon);
        }

        // GET: Icons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Icons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,LecturersID,Day,Time,Availability,Bookroom")] Icon icon)
        {
            if (ModelState.IsValid)
            {
                db.Icons.Add(icon);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(icon);
        }

        // GET: Icons/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Icon icon = await db.Icons.FindAsync(id);
            if (icon == null)
            {
                return HttpNotFound();
            }
            return View(icon);
        }

        // POST: Icons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,LecturersID,Day,Time,Availability,Bookroom")] Icon icon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(icon).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(icon);
        }

        // GET: Icons/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Icon icon = await db.Icons.FindAsync(id);
            if (icon == null)
            {
                return HttpNotFound();
            }
            return View(icon);
        }

        // POST: Icons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Icon icon = await db.Icons.FindAsync(id);
            db.Icons.Remove(icon);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}