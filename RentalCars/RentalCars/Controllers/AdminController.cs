using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RentalCars.Models;
using RentalCars.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace RentalCars.Controllers
{
    [Authorize]
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

        //GET
        public ActionResult New()
        {
            var cars = _context.Cars
                   .Include("Category")
                   .Include("Transmission")
                   .ToList();
            return View(cars);
        }

        //POST
        //public ActionResult New(CarFormViewModel viewModel)
        //{

        //}

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