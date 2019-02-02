using System.ComponentModel.DataAnnotations;

namespace RentalCars.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Firstname is required!")]
        [Display(Name = "First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [Display(Name = "Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(10)]
        public string Phone { get; set; }
    }
}