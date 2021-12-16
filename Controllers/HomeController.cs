using Microsoft.AspNetCore.Mvc;
using PartialViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        private List<Film> listFilms;

        public HomeController()
        {
            listFilms = new List<Film>()
            {
                new Film(){ Title="Film A", Description = "Film A", Duration = "3 Hours", ID = 1 },
                new Film(){ Title="Film B ", Description = "Film B", Duration = "2.5 Hours", ID = 2 },
                new Film(){ Title="Film C", Description = "Film C", Duration = "2 Hours", ID = 3 }
            };
        }

        public async Task<IActionResult> Index()
        {
            return View(listFilms);
        }
    }
}
