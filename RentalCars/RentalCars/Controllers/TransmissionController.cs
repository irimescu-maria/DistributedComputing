using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCars.Controllers
{
    public class TransmissionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransmissionController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Transmission
        public ActionResult Index()
        {
            var transmission = _context.Transmissions.ToList();

            return View(transmission);
        }

        //Add new transmission
        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Transmission transmission)
        {
            var newTransmission = new Transmission
            {
                Type = transmission.Type
            };

            _context.Transmissions.Add(newTransmission);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Edit current trasmission
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var transmission = _context.Transmissions.Single(t => t.Id == id);

            if (transmission == null)
                return HttpNotFound();

            return PartialView(transmission);
        }
    }
}