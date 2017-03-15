using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPrograIV.Models
{
    public class Libros
    {
        public int LibID { get; set; }
        public string LibTitulo { get; set; }
        public string  LibClasificacion { get; set; }
        public int AutID { get; set; }
    }
}