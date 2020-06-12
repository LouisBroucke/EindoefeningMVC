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
            return View();
        }   
        
        [HttpGet]
        public IActionResult BrochureToevoegen()
        {
            Bestemming b = new Bestemming();
            return View(b);
        }

        [HttpPost]
        public IActionResult BrochureToevoegen(Bestemming b)
        {
            if (this.ModelState.IsValid)
            {
                _bestemmingService.Add(b);
                return View("Index");
            }
            else
            {
                return View(b);
            }
        }

        public IActionResult BrochuresTonen()
        {
            if (_bestemmingService != null)
            {
                return View(_bestemmingService.FindAll());
            }
            else
            {
                return View("Index");
            }        
        }
    }
}