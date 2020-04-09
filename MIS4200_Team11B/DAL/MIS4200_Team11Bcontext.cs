using System;
using System.Collections.Generic;
using System.Data.Entity;
using MIS4200_Team11B.Models;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MIS4200_Team11B.DAL
{
    public class MIS4200_Team11Bcontext : DbContext // inherits from DbContext
    {
        
            public MIS4200_Team11Bcontext() : base("name=DefaultConnection")
            {
                // this method is a 'constructor' and is called when a new context is created
                // the base attribute says which connection string to use
            }
            // Include each object here. The value inside <> is the name of the class,
            // the value outside should generally be the plural of the class name
            // and is the name used to reference the entity in code
            public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Recognitions> Recognitions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}