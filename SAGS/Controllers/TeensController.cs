using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using SAGS.DataContext;

namespace SAGS.Controllers
{
    public class TeensController : Controller
    {
        private TeensDb db = new TeensDb();

        // GET: /Teens/
        public ActionResult Index()
        {
            return View(db.Teens.ToList());
        }

        // GET: /Teens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teen teen = db.Teens.Find(id);
            if (teen == null)
            {
                return HttpNotFound();
            }
            return View(teen);
        }

        // GET: /Teens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Teens/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Lastname,Gender,Address,City,DocumentTypeID,Identification")] Teen teen)
        {
            if (ModelState.IsValid)
            {
                db.Teens.Add(teen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teen);
        }

        // GET: /Teens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teen teen = db.Teens.Find(id);
            if (teen == null)
            {
                return HttpNotFound();
            }
            return View(teen);
        }

        // POST: /Teens/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Lastname,Gender,Address,City,DocumentTypeID,Identification")] Teen teen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teen);
        }

        // GET: /Teens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teen teen = db.Teens.Find(id);
            if (teen == null)
            {
                return HttpNotFound();
            }
            return View(teen);
        }

        // POST: /Teens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Teen teen = db.Teens.Find(id);
            db.Teens.Remove(teen);
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
