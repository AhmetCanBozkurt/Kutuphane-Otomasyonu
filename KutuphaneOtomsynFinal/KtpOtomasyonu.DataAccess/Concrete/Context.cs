using KtpOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KtpOtomasyonu.DataAccess.Concrete
{
    public  class Context : DbContext
    {

       public Context()
        {
         Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());

        
       ////CreateDatabaseIfNotExists: This is the default initializer.As the name suggests, it will create the database if none exists as per the configuration. However, if you change the model class and then run the application with this initializer, then it will throw an exception.  
     
       }


        public DbSet<Uyeler> Uyeler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Uyeler>().ToTable("Uyeler");
            base.OnModelCreating(modelBuilder);
        }
        
       

    }
}
