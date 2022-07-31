using Microsoft.EntityFrameworkCore;
using Project_PRG281.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_PRG281.DataService
{
    public class ProjectDataContext : DbContext
    {

        public ProjectDataContext() : base()
        {
         
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLExpress;Initial Catalog=Project_PRG281;Integrated Security=SSPI");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<LoginData> Logins { get; set; }
    }
}
