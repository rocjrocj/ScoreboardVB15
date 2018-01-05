using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScoreboardVB15.Models;
using System.Net;

namespace ScoreboardVB15.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            //var fleets = db.Fleets
            //      .Where(x => x.FleetID == id &&
            //                 x.FleetEvents.Any(f => f.Status == true));
            //var udb = db.ScoreboardVBModels
            //    .Where(s => s.ScoreboardVBModels.Any(m => m.MatchEnded == null));
            var scoreboardVBModels = db.ScoreboardVBModels.SqlQuery("Select * from dbo.ScoreboardVBModels Where MatchEnded Is Null").ToList();
            //return View(db.ScoreboardVBModels.ToList());
            return View(scoreboardVBModels);
        }

        public ActionResult Admin()
        {
            var scoreboardVBModels = db.ScoreboardVBModels.SqlQuery("Select * from dbo.ScoreboardVBModels Where MatchEnded Is Null").ToList();
            return View(scoreboardVBModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Message = "Your feedback page.";

            return View();
        }

        public ActionResult Score(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            if (scoreboardVBModels == null)
            {
                return HttpNotFound();
            }
            return View(scoreboardVBModels);
        }

        public ActionResult KeepScore(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            if (scoreboardVBModels == null)
            {
                return HttpNotFound();
            }
            return View(scoreboardVBModels);
        }
    }
}