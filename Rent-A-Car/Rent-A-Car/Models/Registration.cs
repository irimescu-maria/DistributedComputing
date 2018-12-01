using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
    public class Registration
    {

        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirmation { get; set; }

        public RoleType RoleType { get; set; }
        public byte RoleId { get; set; }
    }
}