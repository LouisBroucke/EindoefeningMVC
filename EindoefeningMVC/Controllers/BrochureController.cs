using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EindoefeningMVC.Models;
using EindoefeningMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EindoefeningMVC.Controllers
{
    public class BrochureController : Controller
    {
        private BestemmingService _bestemmingService;

        public BrochureController(BestemmingService bestemmingService)
        {
            _bestemmingService = bestemmingService;
        }

        public IActionResult Index()
        {
            Bestemming bestemming = new Bestemming();

            ViewBag.bestemmingen = _bestemmingService.FindAll();

            return View(bestemming);
        }   

        [HttpPost]
        public IActionResult BrochureToevoegen(Bestemming b)
        {
            if (this.ModelState.IsValid)
            {
                _bestemmingService.Add(b);
                return RedirectToAction("Index");
            }
            else
            {
                return View(b);
            }
        }

        public IActionResult BrochureVerwijderen(int id)
        {
            _bestemmingService.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult BrochuresAanvragen()
        {
            Response.Cookies.Delete("voornaam");
            return RedirectToAction("Index", "Home");
        }
    }
}