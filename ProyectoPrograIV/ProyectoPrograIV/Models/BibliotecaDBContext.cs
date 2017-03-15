using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoPrograIV.Models
{
    public class BibliotecaDBContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().HasKey(t => t.UsuID);

            modelBuilder.Entity<Autor>().ToTable("Autor");
            modelBuilder.Entity<Autor>().HasKey(t => t.AutID);

            modelBuilder.Entity<Libro>().ToTable("Libro");
            modelBuilder.Entity<Libro>().HasKey(t => t.LibID);

            modelBuilder.Entity<Solicitud>().ToTable("Solicitud");
            modelBuilder.Entity<Solicitud>().HasKey(t => t.UsuID);

            base.OnModelCreating(modelBuilder);
        }
        //public System.Data.Entity.DbSet<ProyectoPrograIV.Models.Usuario> Usuarios { get; set; }

    }
}