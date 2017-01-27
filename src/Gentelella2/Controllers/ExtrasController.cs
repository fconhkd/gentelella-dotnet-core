using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gentelella2.Controllers
{
    public class ExtrasController : Controller
    {
        // GET: /<controller>/
        public IActionResult Level2()
        {
            return View();
        }

        public IActionResult Page403()
        {
            return View();
        }

        public IActionResult Page404()
        {
            return View();
        }

        public IActionResult Page500()
        {
            return View();
        }

        public IActionResult PlainPage()
        {
            return View();
        }

        public IActionResult PricingTables()
        {
            return View();
        }
    }
}
