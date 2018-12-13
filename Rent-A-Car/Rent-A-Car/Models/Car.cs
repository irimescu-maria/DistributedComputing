using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int FabricationYear { get; set; }

        [Required]
        public string Motorization { get; set; }

        [Required]
        public string Option { get; set; }

        [Required]
        public string Photo { get; set; }

        public int CategoryId { get; set; }
        public int TransmissionId { get; set; }
    }
}