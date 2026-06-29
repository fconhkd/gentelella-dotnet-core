using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("~/gentelella/production/user_management.html");
        }

        public IActionResult Users()
        {
            return Redirect("~/gentelella/production/user_management.html");
        }

        public IActionResult Login()
        {
            return Redirect("~/gentelella/production/login.html");
        }
    }
}
