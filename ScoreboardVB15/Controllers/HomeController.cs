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
            return View(db.ScoreboardVBModels.ToList());
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