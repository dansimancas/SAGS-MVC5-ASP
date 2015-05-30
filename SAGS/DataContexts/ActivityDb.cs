using SAGS.DataContexts.ActivityMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace SAGS.DataContexts
{
    public class ActivityDb : DbContext
    {
        public ActivityDb() : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ActivityDb, Configuration>());
        }

        public System.Data.Entity.DbSet<BusinessLogic.Activity> Activities { get; set; }
    }
}