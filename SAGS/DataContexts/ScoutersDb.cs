
using SAGS.DataContexts.ScoutersMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SAGS.DataContexts
{
    public class ScoutersDb : DbContext
    {
        public ScoutersDb()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ScoutersDb, Configuration>());
        }

        public System.Data.Entity.DbSet<BusinessLogic.Scouter> Scouters { get; set; }
    }
}