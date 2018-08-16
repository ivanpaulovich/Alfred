using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Infrastructure.Repositories.EntityFramework
{
    //This class must inherit from DBContext
    public sealed class AlfredDbContext : DbContext
    {
        //The context options will enable us to choose a data source such as SQL DB
        public AlfredDbContext(DbContextOptions options) : base(options)
        {

        }

        //This is the set of entities in the database
        public DbSet<Entities.Account> Accounts { get; set; }
        public DbSet<Entities.Subscriber> Subscribers { get; set; }


        //This method is called when the model for a derived context has been initialized
        //but before the model has been locked down and used to initialize the context.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Entities.Account>().ToTable("Account");

            //modelBuilder.Entity<Entities.Subscriber>().ToTable("Subscriber");
        }


        }
}
