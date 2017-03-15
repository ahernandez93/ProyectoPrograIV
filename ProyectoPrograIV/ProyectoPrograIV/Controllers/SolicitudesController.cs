using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProyectoPrograIV.Models;

namespace ProyectoPrograIV.Controllers
{
    public class SolicitudesController : ApiController
    {
        private BibliotecaDBContext db = new BibliotecaDBContext();

        // GET: api/Solicitudes
        public IQueryable<Solicitud> GetSolicitudes()
        {
            return db.Solicitudes;
        }

        // GET: api/Solicitudes/5
        [ResponseType(typeof(Solicitud))]
        public IHttpActionResult GetSolicitud(int id)
        {
            Solicitud solicitud = db.Solicitudes.Find(id);
            if (solicitud == null)
            {
                return NotFound();
            }

            return Ok(solicitud);
        }

        // PUT: api/Solicitudes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSolicitud(int id, Solicitud solicitud)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != solicitud.UsuID)
            {
                return BadRequest();
            }

            db.Entry(solicitud).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SolicitudExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Solicitudes
        [ResponseType(typeof(Solicitud))]
        public IHttpActionResult PostSolicitud(Solicitud solicitud)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Solicitudes.Add(solicitud);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = solicitud.UsuID }, solicitud);
        }

        // DELETE: api/Solicitudes/5
        [ResponseType(typeof(Solicitud))]
        public IHttpActionResult DeleteSolicitud(int id)
        {
            Solicitud solicitud = db.Solicitudes.Find(id);
            if (solicitud == null)
            {
                return NotFound();
            }

            db.Solicitudes.Remove(solicitud);
            db.SaveChanges();

            return Ok(solicitud);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SolicitudExists(int id)
        {
            return db.Solicitudes.Count(e => e.UsuID == id) > 0;
        }
    }
}