using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Model;

namespace WebStore.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category{categoryName = "Electric car", desc ="Modern mode of transport" },
                     new Category{categoryName = "Car", desc ="Сar with an internal combustion engine" },
                };
            }
        }
    }
}
