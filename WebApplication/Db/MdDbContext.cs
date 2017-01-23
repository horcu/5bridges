using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Xml;
using WebApplication.Models;

namespace WebApplication.Db
{
    public class MdDbContext: DbContext
    {

        public MdDbContext() : base("MdContext")
        {

        }

        static MdDbContext()
        {
           System.Data.Entity.Database.SetInitializer(new MdCountiesInitializer());
        }

        public DbSet<MarylandCounties> Counties { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}