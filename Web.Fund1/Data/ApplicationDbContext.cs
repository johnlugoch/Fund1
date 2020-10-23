using System;
using System.Collections.Generic;
using System.Text;
using Fund.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web.Fund1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

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
