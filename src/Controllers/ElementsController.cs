using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gentelella2.Controllers
{
    public class ElementsController : Controller
    {
        // GET: /<controller>/
        public IActionResult MediaGallery()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult Glyphicons()
        {
            return View();
        }

        public IActionResult Icons()
        {
            return View();
        }

        public IActionResult Inbox()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Invoice()
        {
            return View();
        }

        public IActionResult Typography()
        {
            return View();
        }
        public IActionResult Widgets()
        {
            return View();
        }

    }
}
