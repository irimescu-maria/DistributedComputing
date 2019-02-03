using RentalCars.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentalCars.ViewModels
{
    public class RentFormViewModel
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        public string Username { get; set; }

        public DateTime RentedDate { get; set; }

        public DateTime ReturnedDate { get; set; }

        [Display(Name = "Total Price")]
        public double TotalPrice { get; set; }
        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
    }
}