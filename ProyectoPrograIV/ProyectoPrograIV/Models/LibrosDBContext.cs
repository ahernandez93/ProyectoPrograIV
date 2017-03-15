using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoPrograIV.Models
{
    public class LibrosDBContext : DbContext
    {
        public DbSet<Libros> Libros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libros>().ToTable("Libros");
            modelBuilder.Entity<Libros>().HasKey(t => t.LibID);
            base.OnModelCreating(modelBuilder);
        }
    }
}