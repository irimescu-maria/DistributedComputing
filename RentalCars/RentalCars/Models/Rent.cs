using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentalCars.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        public string Username { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Rented Date")]
        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2")]
        public DateTime RentedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Returned Date")]
        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2")]
        public DateTime ReturnedDate { get; set; }

        [Display(Name = "Total Price")]
        public double TotalPrice { get; set; }

        public virtual Car Car { get; set; }
        public Customer Customer { get; set; }

    }
}