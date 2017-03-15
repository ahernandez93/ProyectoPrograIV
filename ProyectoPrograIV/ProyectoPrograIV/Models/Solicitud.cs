using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPrograIV.Models
{
    public class Solicitud
    {
        public int UsuID { get; set; }
        public int LibID { get; set; }
        public DateTime SolFecha { get; set; }
    }
}