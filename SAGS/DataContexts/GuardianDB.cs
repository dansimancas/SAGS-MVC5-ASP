using Microsoft.AspNet.Identity.EntityFramework;
using SAGS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Text;
using SAGS.DataContexts.GuardiansMigrations;

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