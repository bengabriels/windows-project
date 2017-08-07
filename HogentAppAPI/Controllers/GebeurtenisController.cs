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
using HogentAppAPI.Models;
using HogentAppApi.Models;

namespace HogentAppApi.Controllers
{
    public class GebeurtenisController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Gebeurtenis
        public IQueryable<Gebeurtenis> GetGebeurtenis()
        {
            return db.Gebeurtenis;
        }

        // GET: api/Gebeurtenis/5
        [ResponseType(typeof(Gebeurtenis))]
        public IHttpActionResult GetGebeurtenis(int id)
        {
            Gebeurtenis gebeurtenis = db.Gebeurtenis.Find(id);
            if (gebeurtenis == null)
            {
                return NotFound();
            }

            return Ok(gebeurtenis);
        }

        // PUT: api/Gebeurtenis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGebeurtenis(int id, Gebeurtenis gebeurtenis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gebeurtenis.GebeurtenisId)
            {
                return BadRequest();
            }

            db.Entry(gebeurtenis).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GebeurtenisExists(id))
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

        // POST: api/Gebeurtenis
        [ResponseType(typeof(Gebeurtenis))]
        public IHttpActionResult PostGebeurtenis(Gebeurtenis gebeurtenis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Gebeurtenis.Add(gebeurtenis);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gebeurtenis.GebeurtenisId }, gebeurtenis);
        }

        // DELETE: api/Gebeurtenis/5
        [ResponseType(typeof(Gebeurtenis))]
        public IHttpActionResult DeleteGebeurtenis(int id)
        {
            Gebeurtenis gebeurtenis = db.Gebeurtenis.Find(id);
            if (gebeurtenis == null)
            {
                return NotFound();
            }

            db.Gebeurtenis.Remove(gebeurtenis);
            db.SaveChanges();

            return Ok(gebeurtenis);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GebeurtenisExists(int id)
        {
            return db.Gebeurtenis.Count(e => e.GebeurtenisId == id) > 0;
        }
    }
}