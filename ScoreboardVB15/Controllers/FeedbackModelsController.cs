using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ScoreboardVB15.Models;

namespace ScoreboardVB15.Controllers
{
    public class FeedbackModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FeedbackModels
        public ActionResult Index()
        {
            return View(db.FeedbackModels.ToList());
        }

        // GET: FeedbackModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedbackModels feedbackModels = db.FeedbackModels.Find(id);
            if (feedbackModels == null)
            {
                return HttpNotFound();
            }
            return View(feedbackModels);
        }

        // GET: FeedbackModels/Create
        public ActionResult Create()
        {
            FeedbackModels feedbackModels = new FeedbackModels();
            feedbackModels = SetDefaults(feedbackModels);
            return View(feedbackModels);
        }

        // POST: FeedbackModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,Feedback,FeedbackCreated")] FeedbackModels feedbackModels)
        {
            if (ModelState.IsValid)
            {
                db.FeedbackModels.Add(feedbackModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(feedbackModels);
        }

        // GET: FeedbackModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedbackModels feedbackModels = db.FeedbackModels.Find(id);
            if (feedbackModels == null)
            {
                return HttpNotFound();
            }
            return View(feedbackModels);
        }

        // POST: FeedbackModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,Feedback,FeedbackCreated")] FeedbackModels feedbackModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feedbackModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feedbackModels);
        }

        // GET: FeedbackModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedbackModels feedbackModels = db.FeedbackModels.Find(id);
            if (feedbackModels == null)
            {
                return HttpNotFound();
            }
            return View(feedbackModels);
        }

        // POST: FeedbackModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FeedbackModels feedbackModels = db.FeedbackModels.Find(id);
            db.FeedbackModels.Remove(feedbackModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public FeedbackModels SetDefaults(FeedbackModels feedbackModels)
        {
            feedbackModels.FeedbackCreated = DateTime.Now;
            return feedbackModels;
        }
    }
}
