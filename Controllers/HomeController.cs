using home2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace home2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

       
        public IActionResult about()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }

        public IActionResult services()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }



        public IActionResult Single()
        {
            return View();
        }

    }
    }
