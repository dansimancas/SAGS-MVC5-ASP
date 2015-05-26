using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;


namespace SAGS.Controllers
{
    public class ConfigController : Controller
    {
        // GET: ScoutGroup
        public ActionResult ScoutGroup()
        {

           ScoutGroupManager SManager = new ScoutGroupManager(new SettingsManagerFileStrategy());
           ScoutGroup S = SManager.loadFile();
           return View(S);
        }
    }
}