using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoPrograIV.Models
{
    public class AutoresDBContext : DbContext
    {
        public DbSet<Autores> Autores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autores>().ToTable("Autores");
            modelBuilder.Entity<Autores>().HasKey(t => t.AutID);
            base.OnModelCreating(modelBuilder);
        }
    }
}