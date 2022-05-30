using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Model;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class CarsController : Controller {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory) {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category) {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Electric", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Electric car")).OrderBy(i => i.id);
                }
                else
                {
                    if (string.Equals("Cars", category, StringComparison.OrdinalIgnoreCase))
                    {
                        cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Car")).OrderBy(i => i.id);
                    }
                    currCategory = _category;

                }
            }
                var carObj = new CarsListViewModel
                {
                    allCars = cars,
                    currCategory = currCategory
                };

            ViewBag.Title = "Car page";
            return View(carObj); 
           }
        }
}
