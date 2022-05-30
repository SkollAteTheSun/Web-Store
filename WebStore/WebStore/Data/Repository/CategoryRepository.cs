using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Model;

namespace WebStore.Data.Repository
{
    public class CategoryRepository : ICarsCategory{
        private readonly ApplicationDbContext applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Category> AllCategories => applicationDbContext.Category;
    }
}
