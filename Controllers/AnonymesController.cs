using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationEcoleWeb.Data;
using WebApplicationEcoleWeb.Models;

namespace WebApplicationEcoleWeb.Controllers
{
    public class AnonymesController : Controller
    {
        private WebApplicationEcoleWebContext db = new WebApplicationEcoleWebContext();

        // GET: Anonymes
        public async Task<ActionResult> Index()
        {
            return View(await db.Anonymes.ToListAsync());
        }

        // GET: Anonymes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anonyme anonyme = await db.Anonymes.FindAsync(id);
            if (anonyme == null)
            {
                return HttpNotFound();
            }
            return View(anonyme);
        }

        // GET: Anonymes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anonymes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id")] Anonyme anonyme)
        {
            if (ModelState.IsValid)
            {
                db.Anonymes.Add(anonyme);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(anonyme);
        }

        // GET: Anonymes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anonyme anonyme = await db.Anonymes.FindAsync(id);
            if (anonyme == null)
            {
                return HttpNotFound();
            }
            return View(anonyme);
        }

        // POST: Anonymes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id")] Anonyme anonyme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anonyme).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(anonyme);
        }

        // GET: Anonymes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anonyme anonyme = await db.Anonymes.FindAsync(id);
            if (anonyme == null)
            {
                return HttpNotFound();
            }
            return View(anonyme);
        }

        // POST: Anonymes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Anonyme anonyme = await db.Anonymes.FindAsync(id);
            db.Anonymes.Remove(anonyme);
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
