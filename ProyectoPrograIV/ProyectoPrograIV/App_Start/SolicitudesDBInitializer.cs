using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoPrograIV.Models;

namespace ProyectoPrograIV.App_Start 
{
    public class SolicitudesDBInitializer : DropCreateDatabaseAlways<BibliotecaDBContext>
    {
        protected override void Seed(BibliotecaDBContext context)
        {
            //base.Seed(context);
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