using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Footer()
        {
            return Redirect("~/gentelella/production/fixed_footer.html");
        }

        public IActionResult Sidebar()
        {
            return Redirect("~/gentelella/production/fixed_sidebar.html");
        }
    }
}
