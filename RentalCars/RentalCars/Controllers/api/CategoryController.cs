using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalCars.Controllers.api
{
    public class CategoryController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public CategoryController()
        {
            _context = new ApplicationDbContext();
        }

        //DELETE
        [HttpDelete]
        public void Delete(int id)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (category == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Categories.Remove(category);
            _context.SaveChanges();

        }
    }
}
