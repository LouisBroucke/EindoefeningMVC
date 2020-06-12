using EindoefeningMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindoefeningMVC.Services
{
    public class PersoonService
    {
        private Dictionary<int, Persoon> personen =
            new Dictionary<int, Persoon>();

        public void Add(Persoon p)
        {
            if (personen.Count == 0)
            {
                personen.Add(0, p);
            }
            else
            {
                personen.Add(personen.Keys.Max() + 1, p);
            }            
        }
    }
}
