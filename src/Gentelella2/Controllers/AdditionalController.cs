using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gentelella2.Controllers
{
    public class AdditionalController : Controller
    {
        // GET: /<controller>/
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult ECommerce()
        {
            return View();
        }

        public IActionResult ProjectDetail()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
    }
}
