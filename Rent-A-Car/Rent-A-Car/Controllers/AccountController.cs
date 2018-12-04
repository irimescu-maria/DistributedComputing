using Rent_A_Car.Models;
using Rent_A_Car.ViewModels;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", loginViewModel);
            }
            else
            {

                var validUser =  _context.Registrations.FirstOrDefault(r => r.Username == loginViewModel.Username.ToString()
                                                            && r.Password == loginViewModel.Password.ToString());
                if (validUser != null)
                {
                    var user = new Registration
                    {
                        Username = loginViewModel.Username,
                        Password = loginViewModel.Password,
                    };
                    FormsAuthentication.SetAuthCookie(user.Username, true);
                    return RedirectToAction("Index", "Home");
                }

                //    Status = true;
                //    _context.Registrations.Add(register);
                //       _context.SaveChanges();
            }

            return View(loginViewModel);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}