using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.ulke = "Türkiye";
            //string[] ulkeler = { "Türkiye", "Almanya", "Çin", "Rusya" };
            //ViewBag.ulkeler = ulkeler;

            //ViewData["ulkeler"] = ulkeler;

            //TempData["basvuru"] = "asdadjjjjeEAA";
            ////return View();
            ///
            // return RedirectToAction("Detail");

            //Product product = new Product { ID = 1, Name = "Klavye", Picture = "1.jpg", Price = 520 };
            //Category category = new Category { ID = 1, Name = "Elektronik Kategorisi" };
            //return View(product);


        }

        public IActionResult Detail()
        {
            return View();
        }

        //Controllerden View e veri taşıma
        //1.ViewBAg
        //2 VewData
        //3 Tempdata -- bir defeya mahsus veri almak için 


    }
}