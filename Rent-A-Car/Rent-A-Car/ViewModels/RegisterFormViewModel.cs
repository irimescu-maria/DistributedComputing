using Rent_A_Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rent_A_Car.ViewModels
{
    public class RegisterFormViewModel
    {
        public Registration Registration { get; set; }
        public IEnumerable<RoleType> RoleTypes { get; set; }
    }
}