using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using SAGS.DataContexts;

namespace SAGS.Controllers
{
    public class GuardiansController : Controller
    {
        private GuardiansDb db = new GuardiansDb();

        // GET: /Guardians/
        public ActionResult Index()
        {
            return View(db.Guardians.ToList());
        }

        // GET: /Guardians/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guardian guardian = db.Guardians.Find(id);
            if (guardian == null)
            {
                return HttpNotFound();
            }
            return View(guardian);
        }

        // GET: /Guardians/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Guardians/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Lastname,GenderMember,Address,Document,Identification,City,Telephones,EmailAddresses")] Guardian guardian)
        {
            if (ModelState.IsValid)
            {
                db.Guardians.Add(guardian);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guardian);
        }

        // GET: /Guardians/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guardian guardian = db.Guardians.Find(id);
            if (guardian == null)
            {
                return HttpNotFound();
            }
            return View(guardian);
        }

        // POST: /Guardians/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Lastname,GenderMember,Address,Document,Identification,City,Telephones,EmailAddresses")] Guardian guardian)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guardian).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guardian);
        }

        // GET: /Guardians/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guardian guardian = db.Guardians.Find(id);
            if (guardian == null)
            {
                return HttpNotFound();
            }
            return View(guardian);
        }

        // POST: /Guardians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Guardian guardian = db.Guardians.Find(id);
            db.Guardians.Remove(guardian);
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
