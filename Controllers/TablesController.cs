using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Dynamic()
        {
            return Redirect("~/gentelella/production/tables_dynamic.html");
        }

        public IActionResult Index()
        {
            return Redirect("~/gentelella/production/tables.html");
        }
    }
}
