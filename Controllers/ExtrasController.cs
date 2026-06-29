using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class ExtrasController : Controller
    {
        public IActionResult Level2()
        {
            return Redirect("~/gentelella/production/level2.html");
        }

        public IActionResult Page403()
        {
            return Redirect("~/gentelella/production/page_403.html");
        }

        public IActionResult Page404()
        {
            return Redirect("~/gentelella/production/page_404.html");
        }

        public IActionResult Page500()
        {
            return Redirect("~/gentelella/production/page_500.html");
        }

        public IActionResult PlainPage()
        {
            return Redirect("~/gentelella/production/plain_page.html");
        }

        public IActionResult PricingTables()
        {
            return Redirect("~/gentelella/production/pricing_tables.html");
        }
    }
}
