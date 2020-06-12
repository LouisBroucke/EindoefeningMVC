using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EindoefeningMVC.Models;

namespace EindoefeningMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (Request.Cookies["voornaam"] != null)
            {
                ViewBag.Voornaam = Request.Cookies["voornaam"];
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Persoon");
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CookiesWissen()
        {
            if (Request.Cookies != null)
            {
                if (Request.Cookies["voornaam"] != null)
                {
                    Response.Cookies.Delete("voornaam");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
