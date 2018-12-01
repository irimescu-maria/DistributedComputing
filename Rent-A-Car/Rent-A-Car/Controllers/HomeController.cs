using Rent_A_Car.Models;
using Rent_A_Car.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rent_A_Car.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {

            var role = _context.RoleTypes.ToList();

            var viewModel = new RegisterFormViewModel
            {
                Registration = new Registration(),
                RoleTypes = role
            };
            return View();
        }

        //public ActionResult Register()
        //{
        //}

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
    }
}