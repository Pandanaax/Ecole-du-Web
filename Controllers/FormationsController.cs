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
    public class FormationsController : Controller
    {
        private WebApplicationEcoleWebContext db = new WebApplicationEcoleWebContext();

        // GET: Formations
        public async Task<ActionResult> Index()
        {
            return View(await db.Formations.ToListAsync());
        }

        // GET: Formations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formation formation = await db.Formations.FindAsync(id);
            if (formation == null)
            {
                return HttpNotFound();
            }
            return View(formation);
        }

        // GET: Formations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Titre,Durée,DateDebut,DateFin,NombreInscrit")] Formation formation)
        {
            if (ModelState.IsValid)
            {
                db.Formations.Add(formation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(formation);
        }

        // GET: Formations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formation formation = await db.Formations.FindAsync(id);
            if (formation == null)
            {
                return HttpNotFound();
            }
            return View(formation);
        }

        // POST: Formations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Titre,Durée,DateDebut,DateFin,NombreInscrit")] Formation formation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(formation);
        }

        // GET: Formations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formation formation = await db.Formations.FindAsync(id);
            if (formation == null)
            {
                return HttpNotFound();
            }
            return View(formation);
        }

        // POST: Formations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Formation formation = await db.Formations.FindAsync(id);
            db.Formations.Remove(formation);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
        //Get: Formations/Inscription
        public ActionResult Inscription()
        {
            ViewBag.inscrit = db.Formations.FirstOrDefault().NombreInscrit;

            return View();
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
