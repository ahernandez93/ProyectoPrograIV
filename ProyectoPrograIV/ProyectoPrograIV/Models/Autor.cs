using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPrograIV.Models
{
    public class Autor
    {
        public int AutID { get; set; }
        public string AutNombre { get; set; }
        public char AutGenero { get; set; }
        public string AutDireccion { get; set; }
        public string AutTelefono { get; set; }
    }
}