using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Advanced()
        {
            return Redirect("~/gentelella/production/form_advanced.html");
        }

        public IActionResult Buttons()
        {
            return Redirect("~/gentelella/production/form_buttons.html");
        }

        public IActionResult Form()
        {
            return Redirect("~/gentelella/production/form.html");
        }

        public IActionResult Index()
        {
            return Redirect("~/gentelella/production/form.html");
        }

        public IActionResult Upload()
        {
            return Redirect("~/gentelella/production/form_upload.html");
        }

        public IActionResult Validation()
        {
            return Redirect("~/gentelella/production/form_validation.html");
        }

        public IActionResult Wizard()
        {
            return Redirect("~/gentelella/production/form_wizards.html");
        }
    }
}
