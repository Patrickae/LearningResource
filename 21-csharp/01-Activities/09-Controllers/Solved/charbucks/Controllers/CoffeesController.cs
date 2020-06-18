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
        public string Index()
        {
            return "Coffees Index route.";
        }

        public string About()
        {
            return "Coffees About route.";
        }

        public string Contact()
        {
            return "Coffees Contact route.";
        }
    }
}
