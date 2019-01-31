using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalCars.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 6)]
        public string Name { get; set; }

        [Required]
        [Display(Name= "Fabrication Year")]
        public int FabricationYear { get; set; }

        [Required]
        [StringLength(3)]
        public string Motorization { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 8)]
        public string Option { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Transmission")]
        public int TransmissionId { get; set; }

        //Navigation properties
        public Category Category { get; set; }
        public Transmission Transmission { get; set; }
    }
}