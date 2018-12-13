using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCars.ViewModels
{
    public class CarFormViewModel
    {
        public Car Car { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Transmission> Transmissions { get; set; }
    }
}