using SAGS.DataContexts.TeenMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SAGS.DataContext
{
    public class TeensDb : DbContext
    {
     
        public TeensDb()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TeensDb, Configuration>());
        }

        public System.Data.Entity.DbSet<BusinessLogic.Teen> Teens { get; set; }
    
    }
}
