using Rent_A_Car.Models;
using Rent_A_Car.ViewModels;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Rent_A_Car.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize(Roles = "2")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "2")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "2")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}