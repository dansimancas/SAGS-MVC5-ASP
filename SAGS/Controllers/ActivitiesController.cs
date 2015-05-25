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
using SAGS.DataContexts;


namespace SAGS.Controllers
{
    public class ActivitiesController : Controller
    {
        private ActivityDb db = new ActivityDb();
        private TeensDb db1 = new TeensDb();
        private ScoutersDb db2 = new ScoutersDb();
        private GuardiansDb db3 = new GuardiansDb();

        public ActivitiesController()
        {
            IEnumerable<Teen> Observers1 = db1.Teens.ToList();
            IEnumerable<Scouter> Observers2 = db2.Scouters.ToList();
            IEnumerable<Guardian> Observers3 = db3.Guardians.ToList();

            Activity activity = new Activity();

            foreach (var item in Observers1)
            {
                activity.RegisterObserver(item);
            }

            foreach (var item in Observers2)
            {
                activity.RegisterObserver(item);
            }

            foreach (var item in Observers3)
            {
                activity.RegisterObserver(item);
            }
                         
        }

        // GET: /Activities/
        public ActionResult Index()
        {
            return View(db.Activities.ToList());
        }

        // GET: /Activities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                return HttpNotFound();
            }
            return View(activity);
        }

        // GET: /Activities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Activities/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,BegginingDate,EndingDate,Description")] Activity activity)
        {
            if (ModelState.IsValid)
            {   
                db.Activities.Add(activity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activity);
        }

        // GET: /Activities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                return HttpNotFound();
            }
            return View(activity);
        }

        // POST: /Activities/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,BegginingDate,EndingDate,Description")] Activity activity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activity);
        }

        // GET: /Activities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                return HttpNotFound();
            }
            return View(activity);
        }

        // POST: /Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Activity activity = db.Activities.Find(id);
            db.Activities.Remove(activity);
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
