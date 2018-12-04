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

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()

        {
            var role = _context.RoleTypes.ToList();

            var viewModel = new RegisterFormViewModel
            {
                Registration = new Registration(),
                RoleTypes = role
            };
            return View("RegistrationForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterFormViewModel registerViewModel)
        {
            bool Status = false;
            if (!ModelState.IsValid)
            {
                registerViewModel.RoleTypes = _context.RoleTypes.ToList();

                return View("RegistrationForm", registerViewModel);
            }
            else
            {
                var register = new Registration
                {
                    Username = registerViewModel.Registration.Username,
                    Password = registerViewModel.Registration.Password,
                    PasswordConfirmation = registerViewModel.Registration.PasswordConfirmation,
                    RoleId = registerViewModel.Registration.RoleId
                };

                FormsAuthentication.SetAuthCookie(register.RoleType.Name, true);

                Status = true;
                _context.Registrations.Add(register);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }


            ViewBag.Status = Status;

            return View("RegistrationForm", registerViewModel);
        }

        [Authorize(Roles = RoleName.Admin)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}