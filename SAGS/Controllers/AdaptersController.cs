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
using System.Data.Entity.Validation;
using System.Diagnostics;
using SAGS.DataContext;


namespace SAGS.Controllers
{
    public class AdaptersController : Controller
    {
        private GuardiansDb db = new GuardiansDb();
        private ScoutersDb db1 = new ScoutersDb();
        private TeensDb db2 = new TeensDb();

        //Applying adapter from Guardian to scouter
        public ActionResult GuardianToScouter(int id)
        {
            

            Guardian guardian = db.Guardians.Find(id);
            if (guardian == null)
            {
                return HttpNotFound();
            }

            Scouter scouter = new GuardianToScouterAdapter(guardian);

            if (ModelState.IsValid)
            {
                Activity activity = new Activity();
                activity.UnregisterObserver(guardian);
                scouter.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(scouter);

                Scouter s = (Scouter) scouter;

                try
                {
                    db1.Scouters.Add(s);
                    db1.SaveChanges();
                    db.Guardians.Remove(guardian);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }

                return RedirectToAction("Index", "Scouters");
            }

            return RedirectToAction("Edit", "Guardians", new { id = id });
        }

        //Applying adapter from Teen to scouter
        public ActionResult TeenToScouter(int id)
        {


            Teen teen = db2.Teens.Find(id);
            if (teen == null)
            {
                return HttpNotFound();
            }

            Scouter scouter = new TeenToScouterAdapter(teen);

            if (ModelState.IsValid)
            {
                Activity activity = new Activity();
                activity.UnregisterObserver(teen);
                scouter.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(scouter);

//                Scouter s = (Scouter)scouter;

                try
                {
                    db1.Scouters.Add(scouter);
                    db1.SaveChanges();
                    db2.Teens.Remove(teen);
                    db2.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }

                return RedirectToAction("Index", "Scouters");
            }

            return RedirectToAction("Edit", "Teens", new { id = id });
        }

        //Applying adapter from Scouter to Guardian
        public ActionResult ScouterToGuardian(int id)
        {


            Scouter scouter = db1.Scouters.Find(id);
            if (scouter == null)
            {
                return HttpNotFound();
            }

            Guardian guardian = new ScouterToGuardianAdapter(scouter);

            if (ModelState.IsValid)
            {
                Activity activity = new Activity();
                activity.UnregisterObserver(scouter);
                guardian.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(guardian);

                Guardian g = (Guardian) guardian;

                try
                {
                    db.Guardians.Add(g);
                    db.SaveChanges();
                    db1.Scouters.Remove(scouter);
                    db1.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }

                return RedirectToAction("Index", "Guardians");
            }

            return RedirectToAction("Edit", "Scouter", new { id = id });
        }

    }
}