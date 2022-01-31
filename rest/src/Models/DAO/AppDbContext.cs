using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using rest.src.Models.DTO;
namespace rest.src.Models.DAO
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Constructor to use on a DbConnection that is already opened
        /*public AppDbContext(DbConnection existingConnection, bool contextOwnsConnection)
          : base(existingConnection, contextOwnsConnection)
        {

        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().MapToStoredProcedures();
            modelBuilder.Entity<Address>().MapToStoredProcedures();
            modelBuilder.Entity<Company>().MapToStoredProcedures();
            modelBuilder.Entity<Geopoint>().MapToStoredProcedures();
        }*/

        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Company> Geopoint { get; set; }

    }
}