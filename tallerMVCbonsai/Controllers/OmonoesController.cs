using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using tallerMVCbonsai.Models;

namespace tallerMVCbonsai.Controllers
{
    public class OmonoesController : Controller
    {
        private bonsaiEntities db = new bonsaiEntities();

        // GET: Omonoes
        public ActionResult Index()
        {
            return View(db.Omono.ToList());
        }

        // GET: Omonoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Omono omono = db.Omono.Find(id);
            if (omono == null)
            {
                return HttpNotFound();
            }
            return View(omono);
        }

        // GET: Omonoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Omonoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_Omono,nombre,descripcion,precio")] Omono omono)
        {
            if (ModelState.IsValid)
            {
                db.Omono.Add(omono);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(omono);
        }

        // GET: Omonoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Omono omono = db.Omono.Find(id);
            if (omono == null)
            {
                return HttpNotFound();
            }
            return View(omono);
        }

        // POST: Omonoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_Omono,nombre,descripcion,precio")] Omono omono)
        {
            if (ModelState.IsValid)
            {
                db.Entry(omono).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(omono);
        }

        // GET: Omonoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Omono omono = db.Omono.Find(id);
            if (omono == null)
            {
                return HttpNotFound();
            }
            return View(omono);
        }

        // POST: Omonoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Omono omono = db.Omono.Find(id);
            db.Omono.Remove(omono);
            db.SaveChanges();
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
