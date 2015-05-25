using SAGS.DataContexts.GuardianMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace SAGS.DataContexts
{
    public class GuardianDB : DbContext
    {
        public GuardianDB()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GuardianDB, Configuration>());
        }

        public System.Data.Entity.DbSet<BusinessLogic.Guardian> Guardians { get; set; }
    }
}