using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :base("name = Rent-A-Car")
        {

        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
    }
}