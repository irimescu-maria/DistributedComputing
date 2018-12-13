using Rent_A_Car.Models;
using Rent_A_Car.ViewModels;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.SessionState;

namespace Rent_A_Car.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize(Roles = "1")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
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

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterFormViewModel registerViewModel, string returnUrl)
        {
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

                FormsAuthentication.SetAuthCookie(register.Username, true);
                _context.Registrations.Add(register);
                _context.SaveChanges();
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 &&
                    returnUrl.StartsWith("/") && !returnUrl.StartsWith("//")
                    && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Account");
                }
            }
       }

        [AllowAnonymous]
        [HttpGet]
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", loginViewModel);
            }
            else
            {

                var validUser = _context.Registrations.FirstOrDefault(r => r.Username == loginViewModel.Username.ToString()
                                                           && r.Password == loginViewModel.Password.ToString());
                if (validUser != null)
                {
                    var user = new Registration
                    {
                        Username = loginViewModel.Username,
                        Password = loginViewModel.Password
                    };
                    FormsAuthentication.SetAuthCookie(user.Username, true);

                    if (user.RoleId == 2)
                    { // este logat ca user
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Account");

                    }
                }
            }
            return View(loginViewModel);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Register");
        }
    }
}