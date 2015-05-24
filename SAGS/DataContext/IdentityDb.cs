using Microsoft.AspNet.Identity.EntityFramework;
using SAGS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Text;
using SAGS.Migrations;

namespace SAGS.DataContext
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<IdentityDb, Configuration>());
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}