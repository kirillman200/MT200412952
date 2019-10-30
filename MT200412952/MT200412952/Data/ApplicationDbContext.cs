using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MT200412952.Models;

namespace MT200412952.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MT200412952.Models.MidTerm> MidTerm { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MidTerm>().HasData(
           new Models.MidTerm() { Id = 1, Message = "Midterm Test", Name = "Kiril" },
           new Models.MidTerm() { Id = 2, Message = "New Message", Name = "Kiril" },
           new Models.MidTerm() { Id = 3, Message = "New Message", Name = "Kiril", Date = DateTime.Now }
                );
        }
    }
}
