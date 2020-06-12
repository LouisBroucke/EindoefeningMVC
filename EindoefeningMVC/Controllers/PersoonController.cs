using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EindoefeningMVC.Models;
using EindoefeningMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EindoefeningMVC.Controllers
{
    public class PersoonController : Controller
    {
        private PersoonService _persoonService;

        public PersoonController(PersoonService persoonService)
        {
            _persoonService = persoonService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var persoon = new Persoon();
            return View(persoon);
        }

        [HttpPost]
        public IActionResult Toevoegen(Persoon p)
        {
            if (this.ModelState.IsValid)
            {
                _persoonService.Add(p);
                Response.Cookies.Append("voornaam", p.Voornaam);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index", p);
            }
        }
    }
}