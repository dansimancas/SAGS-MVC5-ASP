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
using BusinessLogic.Patterns.Strategy.NotificationStrategy;

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

            IEnumerable<Teen> Observers1 = db1.Teens.ToList();
            IEnumerable<Scouter> Observers2 = db2.Scouters.ToList();
            IEnumerable<Guardian> Observers3 = db3.Guardians.ToList();

            Activity activity = new Activity();

            foreach (var item in Observers1)
            {
                item.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(item);
            }

            foreach (var item in Observers2)
            {
                item.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(item);
            }

            foreach (var item in Observers3)
            {
                item.setStrategy(new EmailNotificationStrategy());
                activity.RegisterObserver(item);
            }
                         
       
        }
    }
}
