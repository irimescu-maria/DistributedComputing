using RentalCars.Models;
using RentalCars.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalCars.Controllers.api
{
    public class CarsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

     

        //DELETE /api/cars/1
        [HttpDelete]
        public void Delete(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Cars.Remove(car);
            _context.SaveChanges();
        }
    }
}
