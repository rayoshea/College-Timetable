using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TallaghtTimetable.Models;

namespace TallaghtTimetable.Controllers
{
    public class StudiesController : Controller
    {
        private RoomDBContext db = new RoomDBContext();

        // GET: Studies
        public async Task<ActionResult> Index()
        {
            return View(await db.Studys.ToListAsync());
        }

        // GET: Studies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Study study = await db.Studys.FindAsync(id);
            if (study == null)
            {
                return HttpNotFound();
            }
            return View(study);
        }

        // GET: Studies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,LecturersID,Day,Time,Availability,Bookroom")] Study study)
        {
            if (ModelState.IsValid)
            {
                db.Studys.Add(study);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(study);
        }

        // GET: Studies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Study study = await db.Studys.FindAsync(id);
            if (study == null)
            {
                return HttpNotFound();
            }
            return View(study);
        }

        // POST: Studies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,LecturersID,Day,Time,Availability,Bookroom")] Study study)
        {
            if (ModelState.IsValid)
            {
                db.Entry(study).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(study);
        }

        // GET: Studies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Study study = await db.Studys.FindAsync(id);
            if (study == null)
            {
                return HttpNotFound();
            }
            return View(study);
        }

        // POST: Studies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Study study = await db.Studys.FindAsync(id);
            db.Studys.Remove(study);
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