using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class ElementsController : Controller
    {
        public IActionResult MediaGallery()
        {
            return Redirect("~/gentelella/production/media_gallery.html");
        }

        public IActionResult Calendar()
        {
            return Redirect("~/gentelella/production/calendar.html");
        }

        public IActionResult Glyphicons()
        {
            return Redirect("~/gentelella/production/icons.html");
        }

        public IActionResult Icons()
        {
            return Redirect("~/gentelella/production/icons.html");
        }

        public IActionResult Inbox()
        {
            return Redirect("~/gentelella/production/inbox.html");
        }

        public IActionResult Index()
        {
            return Redirect("~/gentelella/production/general_elements.html");
        }

        public IActionResult Invoice()
        {
            return Redirect("~/gentelella/production/invoice.html");
        }

        public IActionResult Typography()
        {
            return Redirect("~/gentelella/production/typography.html");
        }

        public IActionResult Widgets()
        {
            return Redirect("~/gentelella/production/widgets.html");
        }
    }
}
