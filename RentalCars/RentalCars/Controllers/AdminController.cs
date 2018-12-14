using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RentalCars.Models;
using RentalCars.ViewModels;
using System;
using System.Data.Entity.Migrations;
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
        [HttpGet]
        public ActionResult New()
        {
            var categories = _context.Categories.ToList();
            var transmissions = _context.Transmissions.ToList();

            var viewModel = new CarFormViewModel()
            {
                Car = new Car(),
                Categories = categories,
                Transmissions = transmissions
            };
            return View(viewModel);
        }

        //POST
        [HttpPost]
        public ActionResult New(Car car)
        {
            var newCar = new Car
            {
                Name = car.Name,
                FabricationYear = car.FabricationYear,
                Motorization = car.Motorization,
                Option = car.Option,
                Photo = car.Photo,
                CategoryId = car.CategoryId,
                TransmissionId = car.TransmissionId
            };

            _context.Cars.Add(newCar);
            _context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        //EDIT
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CarFormViewModel()
            {
                Car = car,
                Categories = _context.Categories.ToList(),
                Transmissions = _context.Transmissions.ToList()
            };

            return PartialView(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(Car car)
        {
            var categories = _context.Categories.ToList();
            var transmissions = _context.Transmissions.ToList();


            var editCar = _context.Cars.Single(c => c.Id == car.Id);

            if (car.Id > 0)
            {
                editCar.Id = car.Id;
                editCar.Name = car.Name;
                editCar.FabricationYear = car.FabricationYear;
                editCar.Motorization = car.Motorization;
                editCar.Option = car.Option;
                editCar.Photo = car.Photo;
                editCar.TransmissionId = car.TransmissionId;
                editCar.CategoryId = car.CategoryId;

                _context.Cars.AddOrUpdate(editCar);
                _context.SaveChanges();
            }

            return View("Index");
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