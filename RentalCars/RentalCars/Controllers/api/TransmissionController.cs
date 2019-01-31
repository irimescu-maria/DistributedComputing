using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalCars.Controllers.api
{
    public class TransmissionController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public TransmissionController()
        {
            _context = new ApplicationDbContext();
        }

        //Delete
        [HttpDelete]
        public void Delete(int id)
        {
            var transmission = _context.Transmissions.SingleOrDefault(c => c.Id == id);

            if (transmission == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Transmissions.Remove(transmission);
            _context.SaveChanges();
        }
    }
}
