using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("~/gentelella/production/index.html");
        }

        public IActionResult Index2()
        {
            return Redirect("~/gentelella/production/index2.html");
        }

        public IActionResult Index3()
        {
            return Redirect("~/gentelella/production/index3.html");
        }

        public IActionResult Index4()
        {
            return Redirect("~/gentelella/production/index4.html");
        }

        public IActionResult Error()
        {
            return Redirect("~/gentelella/production/page_500.html");
        }
    }
}
