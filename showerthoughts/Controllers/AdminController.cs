using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using showerthoughts.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace showerthoughts.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
       public ApplicationDbContext db_getUsers = new ApplicationDbContext();
       public ApplicataionMainDbContext db_getMain = new ApplicataionMainDbContext();
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult getUsers()
        {            
            return PartialView(db_getUsers.Users.ToList());
        }

        public PartialViewResult getRoles()
        {
            List<IdentityRole> roles = db_getUsers.Roles.ToList();

            return PartialView(roles);
        }

        [HttpGet]
        public PartialViewResult createRole()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult createRole(IdentityRole role)
        {
            if (ModelState.IsValid)
            {                
                db_getUsers.Roles.Add(role);
                db_getUsers.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {            
            var tmp = db_getMain.Database.SqlQuery<string>("SELECT Name FROM showerthoughts.dbo.AspNetRoles").ToList();
            SelectList list_role = new SelectList(tmp);

            ViewBag.list_role = list_role;

            //var tmp1 = db_getMain.Database.ExecuteSqlCommand()
            ApplicationUser user = db_getUsers.Users.Find(Id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(ApplicationUser user)
        {
            //ApplicationUser user = db_getUsers.Users.Find(Id);

            if (TryUpdateModel(user))
            {
                db_getUsers.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}