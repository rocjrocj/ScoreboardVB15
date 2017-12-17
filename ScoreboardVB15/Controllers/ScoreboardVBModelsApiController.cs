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
using ScoreboardVB15.Models;

namespace ScoreboardVB15.Controllers
{
    public class ScoreboardVBModelsApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ScoreboardVBModelsApi
        public IQueryable<ScoreboardVBModels> GetScoreboardVBModels()
        {
            return db.ScoreboardVBModels;
        }

        // GET: api/ScoreboardVBModelsApi/5
        [ResponseType(typeof(ScoreboardVBModels))]
        public IHttpActionResult GetScoreboardVBModels(int id)
        {
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            if (scoreboardVBModels == null)
            {
                return NotFound();
            }

            return Ok(scoreboardVBModels);
        }

        // PUT: api/ScoreboardVBModelsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutScoreboardVBModels(int id, ScoreboardVBModels scoreboardVBModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != scoreboardVBModels.Id)
            {
                return BadRequest();
            }

            db.Entry(scoreboardVBModels).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreboardVBModelsExists(id))
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

        // POST: api/ScoreboardVBModelsApi
        [ResponseType(typeof(ScoreboardVBModels))]
        public IHttpActionResult PostScoreboardVBModels(ScoreboardVBModels scoreboardVBModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ScoreboardVBModels.Add(scoreboardVBModels);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = scoreboardVBModels.Id }, scoreboardVBModels);
        }

        // DELETE: api/ScoreboardVBModelsApi/5
        [ResponseType(typeof(ScoreboardVBModels))]
        public IHttpActionResult DeleteScoreboardVBModels(int id)
        {
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            if (scoreboardVBModels == null)
            {
                return NotFound();
            }

            db.ScoreboardVBModels.Remove(scoreboardVBModels);
            db.SaveChanges();

            return Ok(scoreboardVBModels);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ScoreboardVBModelsExists(int id)
        {
            return db.ScoreboardVBModels.Count(e => e.Id == id) > 0;
        }
    }
}