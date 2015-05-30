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
        ScoutGroupManager SManager;
        public ConfigController()
        {
            SManager = new ScoutGroupManager(new JsonFileManagerStrategy());
        }

        // GET: ScoutGroup
        public ActionResult ScoutGroup()
        {
           ScoutGroup S = SManager.loadFile();
           return View(S);
        }

        [HttpPost]
        public ActionResult ScoutGroup([Bind(Include = "Name,Number,City,State,Country,Address,Telephones,Sponsor")] ScoutGroup scoutgroup)
        {
            if (ModelState.IsValid)
            {
                SManager.writeFile(scoutgroup);
                return RedirectToAction("ScoutGroup");
            }

            return View(scoutgroup);
        }
    }
}