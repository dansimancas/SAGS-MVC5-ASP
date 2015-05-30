using SAGS.DataContexts.GuardianMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace SAGS.DataContexts
{
    public class GuardiansDb : DbContext
    {
        public GuardiansDb()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GuardiansDb, Configuration>());
        }

        public System.Data.Entity.DbSet<BusinessLogic.Guardian> Guardians { get; set; }
    }
}