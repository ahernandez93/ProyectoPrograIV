using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPrograIV.Models
{
    public class Usuarios
    {
        public int UsuID { get; set; }
        public string UsuNombre { get; set; }
        public char UsuGenero { get; set; }
        public string UsuCorreo { get; set; }
        public string UsuTelefono { get; set; }
        public string UsuRol { get; set; }
    }
}