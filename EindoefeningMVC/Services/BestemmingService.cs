using EindoefeningMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindoefeningMVC.Services
{
    public class BestemmingService
    {
        private Dictionary<int, Bestemming> bestemmingen =
            new Dictionary<int, Bestemming>();

        public void Add(Bestemming b)
        {
            if (bestemmingen.Count == 0)
            {
                bestemmingen.Add(0, b);
            }
            else
            {
                bestemmingen.Add(bestemmingen.Keys.Max() + 1, b);
            }
        }

        public List<Bestemming> FindAll()
        {
            return bestemmingen.Values.ToList();
        }
    }
}
