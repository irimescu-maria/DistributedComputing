using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Nexmo.Api;
using RentalCars.Models;
using RentalCars.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace RentalCars.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Users
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                
                var cars = _context.Cars.ToList();
                
                var user = User.Identity;
                ViewBag.Name = user.Name;
                ViewBag.displayMenu = "No";
                if (isAdminUser())
                {
                    ViewBag.displayMenu = "Yes";
                }
                return View(cars);
            }
            else
            {
                ViewBag.Name = "Not Logged IN";
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            var viewModel = new CarFormViewModel()
            {
                Car = car,
                Categories = _context.Categories.ToList(),
                Transmissions = _context.Transmissions.ToList()
            };

            return View(viewModel);
        }

        //GET
        [HttpGet]
        [Authorize]
        public ActionResult Rent(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            var rent = new Rent();
            var viewModel = new RentFormViewModel()
            {
                Car = car,
                Customer = rent.Customer,
                Username = User.Identity.Name,
                RentedDate = DateTime.Now,
                CarId=car.Id
                
            };
         
         
            return View(viewModel);
        }

        //POST
        [HttpPost]
        public ActionResult Rent(Rent rent)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == rent.CarId);
            var newRent = new Rent()
            {
                Username = rent.Username,
                TotalPrice = rent.TotalPrice,
                ReturnedDate = rent.ReturnedDate,
                RentedDate = rent.RentedDate,
                CustomerId = rent.CustomerId,
                Customer = new Customer
                {
                    Id = rent.CustomerId,
                    FirstName = rent.Customer.FirstName,
                    LastName = rent.Customer.LastName,
                    Phone = rent.Customer.Phone
                },
                CarId = car.Id
            };

          
            _context.Rents.Add(newRent);
            _context.SaveChanges();


            return RedirectToAction("Complete", new { id = newRent.Id });
        }

        //GET
        public ActionResult Complete(int id)
        {
            //Validate customer owns this order
            bool isValid = _context.Rents.Include("Customer").Any(
               o => o.Id == id &&
               o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }

        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_context));
                var s = UserManager.GetRoles(user.GetUserId());
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