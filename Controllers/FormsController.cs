using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gentelella2.Controllers
{
    public class FormsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Advanced()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult Validation()
        {
            return View();
        }

        public IActionResult Wizard()
        {
            return View();
        }
    }
}
