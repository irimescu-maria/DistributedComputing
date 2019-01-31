using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCars.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customer
        public ActionResult getAllCars()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
        }
    }
}