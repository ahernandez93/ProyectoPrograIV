using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoPrograIV.Models
{
    public class SolicitudesDBContext : DbContext
    {
        public DbSet<Solicitudes> Solicitudes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Solicitudes>().ToTable("Solicitudes");
            modelBuilder.Entity<Solicitudes>().HasKey(t => t.UsuID);
            base.OnModelCreating(modelBuilder);
        }
    }
}