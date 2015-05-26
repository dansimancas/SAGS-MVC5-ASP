
using SAGS.DataContexts.ScoutersMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BusinessLogic;


namespace SAGS.DataContexts
{
    public class ScoutersDb : DbContext
    {
        public ScoutersDb()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ScoutersDb, Configuration>());
        }

        public DbSet<Scouter> Scouters { get; set; }
    }
}