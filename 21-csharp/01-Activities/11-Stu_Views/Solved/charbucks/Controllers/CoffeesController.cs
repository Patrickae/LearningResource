using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using charbucks.Models;

namespace charbucks.Controllers
{
    public class CoffeesController : Controller
    {
        public IActionResult Index(string firstName, string lastName)
        {
            ViewData["FirstName"] = firstName ?? "Darin";
            ViewData["LastName"] = lastName ?? "Boesch";

            return View();
        }

        public IActionResult About()
        {
            ViewData["AppName"] = "Badass Coffee";

            return View();
        }

        public string Contact()
        {
            return "Coffees Contact route.";
        }
    }
}
