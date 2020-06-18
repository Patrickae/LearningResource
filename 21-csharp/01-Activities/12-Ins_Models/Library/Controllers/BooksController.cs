using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private MyDbContext db = new MyDbContext();

        public IActionResult Index()
        {
            return View(db.Books.ToList());
        }
    }
}
