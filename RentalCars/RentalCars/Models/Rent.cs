using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCars.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        public DateTime RentedDate { get; set; }
        public DateTime ReturnedDate { get; set; }


        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }

    }
}