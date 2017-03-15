using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoPrograIV.Models;

namespace ProyectoPrograIV.App_Start
{
    public class LibrosDBInitializer : DropCreateDatabaseAlways<BibliotecaDBContext>
    {
        protected override void Seed(BibliotecaDBContext context)
        {
            //base.Seed(context);
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
        }
    }
}