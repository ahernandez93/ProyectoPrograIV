using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoPrograIV.Models;

namespace ProyectoPrograIV.App_Start
{
    public class UsuariosDBInitializer : DropCreateDatabaseAlways<BibliotecaDBContext>
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
        }
    }
}