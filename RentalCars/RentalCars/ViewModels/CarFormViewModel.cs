using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalCars.ViewModels
{
    public class CarFormViewModel
    {
        [Required]
        public Car Car { get; set; }

        [Required]
        public IEnumerable<Category> Categories { get; set; }

        [Required]
        public IEnumerable<Transmission> Transmissions { get; set; }
    }
}