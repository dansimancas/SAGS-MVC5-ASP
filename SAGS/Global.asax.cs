using SAGS.DataContext;
using SAGS.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BusinessLogic;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace SAGS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private TeensDb db1 = new TeensDb();
        private ScoutersDb db2 = new ScoutersDb();
        private GuardiansDb db3 = new GuardiansDb();

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Activity activity = new Activity();

            IEnumerable<Teen> Observers1 = db1.Teens.ToList();
            foreach (var item in Observers1)
            {
                item.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(item);
            }

            IEnumerable<Scouter> Observers2 = db2.Scouters.ToList();
            foreach (var item in Observers2)
            {
                item.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(item);
            }
            IEnumerable<Guardian> Observers3 = db3.Guardians.ToList();
            foreach (var item in Observers3)
            {
                item.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(item);
            }
            /*catch(Exception e) {
                 Console.WriteLine ("In catch block of Main method.");
                 Console.WriteLine("Caught: {0}", e.Message);
                 if (e.InnerException != null)
                    Console.WriteLine("Inner exception: {0}", e.InnerException);
              }*/
        }
    }
}
