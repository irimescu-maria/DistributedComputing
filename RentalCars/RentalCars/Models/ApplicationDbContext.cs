using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace RentalCars.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }


        public ApplicationDbContext()
            : base("RentalCars", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        
    }
}