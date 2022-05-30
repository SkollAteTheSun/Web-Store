using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Model;

namespace WebStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars { get; set; }
    }
}
