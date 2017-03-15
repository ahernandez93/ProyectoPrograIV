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
    public class LibrosController : ApiController
    {
        private BibliotecaDBContext db = new BibliotecaDBContext();

        // GET: api/Libros
        public IQueryable<Libro> GetLibros()
        {
            return db.Libros;
        }

        // GET: api/Libros/5
        [ResponseType(typeof(Libro))]
        public IHttpActionResult GetLibro(int id)
        {
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            return Ok(libro);
        }

        // PUT: api/Libros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLibro(int id, Libro libro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != libro.LibID)
            {
                return BadRequest();
            }

            db.Entry(libro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroExists(id))
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

        // POST: api/Libros
        [ResponseType(typeof(Libro))]
        public IHttpActionResult PostLibro(Libro libro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Libros.Add(libro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = libro.LibID }, libro);
        }

        // DELETE: api/Libros/5
        [ResponseType(typeof(Libro))]
        public IHttpActionResult DeleteLibro(int id)
        {
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            db.Libros.Remove(libro);
            db.SaveChanges();

            return Ok(libro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LibroExists(int id)
        {
            return db.Libros.Count(e => e.LibID == id) > 0;
        }
    }
}