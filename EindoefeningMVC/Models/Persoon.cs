using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EindoefeningMVC.Models
{
    public class Persoon
    {
        [Required(ErrorMessage ="Naam is een verplicht veld")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Voornaam is een verplicht veld")]
        public string Voornaam { get; set; }

        [Required(ErrorMessage = "Adres is een verplicht veld")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Postcode is een verplicht veld")]
        [Range(1000, 9999, ErrorMessage ="Postcode moet tussen {1} en {2} liggen")]
        public int Postcode { get; set; }

        [Required(ErrorMessage = "Gemeente is een verplicht veld")]
        public string Gemeente { get; set; }

        [Required(ErrorMessage = "Email is een verplicht veld")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefoon is een verplicht veld")]
        public string Telefoon { get; set; }
    }
}
