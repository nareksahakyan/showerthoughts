using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using showerthoughts.Models;

namespace showerthoughts.Controllers
{
    public class AdminController : Controller
    {
       public ApplicationDbContext db_getUsers = new ApplicationDbContext();
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult getUsers()
        {
            return PartialView(db_getUsers.Users.ToList());
        }
    }
}