using Fund.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Fund1.Models
{
    public class FundContext : IdentityDbContext
    {
        public FundContext(DbContextOptions<FundContext> options) : base(options) { }

        public DbSet<Group> group { get; set; }


        public DbSet<Person> person { get; set; }


        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasIndex(t => t.name)
                .IsUnique();

            modelBuilder.Entity<Group>()
               .HasIndex(t => t.name)
               .IsUnique();
        }
    }
}

