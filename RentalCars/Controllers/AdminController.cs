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
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Admin
        //This method displays all the car from the database
        public ActionResult Index()
        {
            if (isAdminUser())
            {
                var cars = _context.Cars
                    .Include("Category")
                    .Include("Transmission")
                    .ToList();
                return View(cars);
            }
            else
            {
                return View("Index", "Home");
            }
            
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