using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoPrograIV.Models;

namespace ProyectoPrograIV.App_Start
{
    public class BibliotecaDBInitializer : DropCreateDatabaseAlways<BibliotecaDBContext>
    {
        protected override void Seed(BibliotecaDBContext context)
        {
            //base.Seed(context);
            var Usuarios = new List<Usuario>
            {
                new Usuario {UsuID = 1, UsuNombre = "Allan Hernandez", UsuGenero = 'M', UsuCorreo = "allan_hc@outlook.com", UsuTelefono = "9706-7787", UsuRol = "Administrador" },
                new Usuario {UsuID = 2, UsuNombre = "Jose Hernandez", UsuGenero = 'M', UsuCorreo = "jose@outlook.com", UsuTelefono = "9706-7787", UsuRol = "Administrador" },
                new Usuario {UsuID = 3, UsuNombre = "Alex Hernandez", UsuGenero = 'M', UsuCorreo = "alex@outlook.com", UsuTelefono = "9706-7787", UsuRol = "Administrador" },
                new Usuario {UsuID = 4, UsuNombre = "Rene Hernandez", UsuGenero = 'M', UsuCorreo = "rene@outlook.com", UsuTelefono = "9706-7787", UsuRol = "Administrador" },
                new Usuario {UsuID = 5, UsuNombre = "Javier Hernandez", UsuGenero = 'M', UsuCorreo = "javier@outlook.com", UsuTelefono = "9706-7787", UsuRol = "Administrador" }
            };

            Usuarios.ForEach(c => context.Usuario.Add(c));
            context.SaveChanges();

            var Autores = new List<Autor>
            {
                new Autor {AutID = 1001, AutNombre = "Ramon Amaya Amador", AutGenero = 'M', AutDireccion = "Col Los Castaños", AutTelefono = "9706-7787"},
                new Autor {AutID = 1002, AutNombre = "Ramon Amaya Amador", AutGenero = 'M', AutDireccion = "Col Los Castaños", AutTelefono = "9706-7787"},
                new Autor {AutID = 1003, AutNombre = "Ramon Amaya Amador", AutGenero = 'M', AutDireccion = "Col Los Castaños", AutTelefono = "9706-7787"},
                new Autor {AutID = 1004, AutNombre = "Ramon Amaya Amador", AutGenero = 'M', AutDireccion = "Col Los Castaños", AutTelefono = "9706-7787"},
                new Autor {AutID = 1005, AutNombre = "Ramon Amaya Amador", AutGenero = 'M', AutDireccion = "Col Los Castaños", AutTelefono = "9706-7787"}
            };

            Autores.ForEach(c => context.Autores.Add(c));
            context.SaveChanges();

            var Libros = new List<Libro>
            {
                new Libro {LibID = 2001, LibTitulo = "Quien se ha llevado mi queso", LibClasificacion = "Literatura", AutID = 1001},
                new Libro {LibID = 2002, LibTitulo = "El conde de Montecristo", LibClasificacion = "Literatura", AutID = 1002},
                new Libro {LibID = 2003, LibTitulo = "El coronel no tiene quien le escriba", LibClasificacion = "Literatura", AutID = 1002},
                new Libro {LibID = 2004, LibTitulo = "Cronicas de una muerte anunciada", LibClasificacion = "Novela", AutID = 1003},
                new Libro {LibID = 2005, LibTitulo = "El perfume", LibClasificacion = "Novela", AutID = 1004}
            };

            Libros.ForEach(c => context.Libros.Add(c));
            context.SaveChanges();

            var Solicitudes = new List<Solicitud>
            {
                new Solicitud {UsuID = 1, LibID = 2001, SolFecha = Convert.ToDateTime("03-03-2017")},
                new Solicitud {UsuID = 2, LibID = 2002, SolFecha = Convert.ToDateTime("04-03-2017")},
                new Solicitud {UsuID = 2, LibID = 2002, SolFecha = Convert.ToDateTime("04-03-2017")},
                new Solicitud {UsuID = 1, LibID = 2003, SolFecha = Convert.ToDateTime("05-03-2017")},
                new Solicitud {UsuID = 3, LibID = 2001, SolFecha = Convert.ToDateTime("05-03-2017")}
            };

            Solicitudes.ForEach(c => context.Solicitudes.Add(c));
            context.SaveChanges();
        }
    }
}