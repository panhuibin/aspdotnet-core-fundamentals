using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryCuisineData : ICuisineData
    {
        public InMemoryCuisineData()
        {
            _cuisines = new List<Cuisine>
            {
                new Cuisine { Id = 1, Name = "Pizza"},
                new Cuisine { Id = 2, Name = "Spaghetti"},
                new Cuisine { Id = 3, Name = "Noodle"}
            };
        }
        
        public IEnumerable<Cuisine> GetAll()
        {
            return _cuisines.OrderBy(r => r.Name);
        }

        List<Cuisine> _cuisines;
    }
}
