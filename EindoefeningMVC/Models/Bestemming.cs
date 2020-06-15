using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EindoefeningMVC.Models
{
    public class Bestemming
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Gelieve een bestemming in te geven")]
        public string Naam { get; set; }
    }
}
