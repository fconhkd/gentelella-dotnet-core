using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class AdditionalController : Controller
    {
        public IActionResult Contacts()
        {
            return Redirect("~/gentelella/production/contacts.html");
        }

        public IActionResult ECommerce()
        {
            return Redirect("~/gentelella/production/e_commerce.html");
        }

        public IActionResult ProjectDetail()
        {
            return Redirect("~/gentelella/production/project_detail.html");
        }

        public IActionResult Projects()
        {
            return Redirect("~/gentelella/production/projects.html");
        }

        public IActionResult Profile()
        {
            return Redirect("~/gentelella/production/profile.html");
        }
    }
}
