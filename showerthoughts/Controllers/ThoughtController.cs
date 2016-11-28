using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using showerthoughts.Models;

namespace showerthoughts.Controllers
{
    public class ThoughtController : Controller
    {
        showerthoughtsDBContext db = new showerthoughtsDBContext();

        // GET: Thought
        public ActionResult Index()
        {
            return View(db.thoughts.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]        
        public ActionResult Create(thought thought)
        {
            thought.rate = 0;            

            if (ModelState.IsValid)
            {
                db.thoughts.Add(thought);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult goToThought(int id)
        {
            thought thought = db.thoughts.Find(id);
            return View(thought);
        }

    }
}