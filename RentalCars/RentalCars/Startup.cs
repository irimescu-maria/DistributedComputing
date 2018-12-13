using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalCars.Startup))]
namespace RentalCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
