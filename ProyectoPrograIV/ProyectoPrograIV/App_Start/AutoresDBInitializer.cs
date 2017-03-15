using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoPrograIV.Models;

namespace ProyectoPrograIV.App_Start 
{
    public class AutoresDBInitializer : DropCreateDatabaseAlways<BibliotecaDBContext>
    {
        protected override void Seed(BibliotecaDBContext context)
        {
            //base.Seed(context);
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
        }
    }
}