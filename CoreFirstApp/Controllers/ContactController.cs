using CoreFirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreFirstApp.Controllers
{
    public class ContactController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string ad, string soyad)
		{
			return View();
		}

		public IActionResult ContactForm()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ContactForm(Contact model)
		{
			if (ModelState.IsValid)
			{
				//post işlemi yapılacak yer 

				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}
		}
	}
}
