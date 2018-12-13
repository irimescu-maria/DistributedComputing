using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCars.Controllers
{
    public class RoleController : Controller
    {
        private ApplicationDbContext _context;

        public RoleController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Role
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!isAdminUser())
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            var roles = _context.Roles.ToList();
            return View();
        }

        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;

                var userManager = new UserManager<ApplicationUser>
                    (new UserStore<ApplicationUser>(_context));

                var s = userManager.GetRoles(user.GetUserId());

                if (s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}