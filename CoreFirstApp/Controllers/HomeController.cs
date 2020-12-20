using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ulke = "Turkiye";
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        //Controllerden View e veri taşıma
        //1.ViewBAg

    }
}