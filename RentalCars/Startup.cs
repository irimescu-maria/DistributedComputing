using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using RentalCars.Models;

[assembly: OwinStartupAttribute(typeof(RentalCars.Startup))]
namespace RentalCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            createRolesAndUsers();
        }

        //In this method we will create default User roles and Admin user
        //for login
        private void createRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
           

            //In Startup i created first Admin Role and I created a default Admin
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                //first I create Admin role
                role.Name = "Admin";
                roleManager.Create(role);

                //Here I create an Admin super user who will maintain
                //the website
                var user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";

                string password = "Alexandra@96";
                var checkUser = userManager.Create(user, password);

                //Add default User to Role Admin
                if (checkUser.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "Admin");
                }
            }

            //Creating Customer role
            if (!roleManager.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
        }
    }
}
