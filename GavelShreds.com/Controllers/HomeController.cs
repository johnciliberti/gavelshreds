using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GavelShreds.com.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Band()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Music()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult News()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Events()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Video()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Fans()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
