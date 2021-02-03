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
    public class shohinsController : Controller
    {
        private bonsaiEntities db = new bonsaiEntities();

        // GET: shohins
        public ActionResult Index()
        {
            return View(db.shohin.ToList());
        }

        // GET: shohins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            shohin shohin = db.shohin.Find(id);
            if (shohin == null)
            {
                return HttpNotFound();
            }
            return View(shohin);
        }

        // GET: shohins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: shohins/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_shohin,nombre,descripcion,precio")] shohin shohin)
        {
            if (ModelState.IsValid)
            {
                db.shohin.Add(shohin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shohin);
        }

        // GET: shohins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            shohin shohin = db.shohin.Find(id);
            if (shohin == null)
            {
                return HttpNotFound();
            }
            return View(shohin);
        }

        // POST: shohins/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_shohin,nombre,descripcion,precio")] shohin shohin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shohin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shohin);
        }

        // GET: shohins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            shohin shohin = db.shohin.Find(id);
            if (shohin == null)
            {
                return HttpNotFound();
            }
            return View(shohin);
        }

        // POST: shohins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            shohin shohin = db.shohin.Find(id);
            db.shohin.Remove(shohin);
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
