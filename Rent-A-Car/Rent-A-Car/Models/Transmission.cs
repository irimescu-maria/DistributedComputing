﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
    public class Transmission
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}