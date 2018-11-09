using System.Data.Entity;

namespace StatisticalApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=StatisticalApp")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
