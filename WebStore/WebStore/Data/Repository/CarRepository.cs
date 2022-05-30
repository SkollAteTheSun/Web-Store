using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Model;

namespace WebStore.Data.Repository
{
    public class CarRepository : IAllCars{

        private readonly ApplicationDbContext applicationDbContext;

        public CarRepository(ApplicationDbContext applicationDbContext){
            this.applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Car> Cars => applicationDbContext.Car.Include(c=>c.Category);

        public IEnumerable<Car> getFavCars => applicationDbContext.Car.Where(p => p.isFavorite).Include(c => c.Category);

        public Car getObjectCar(int carId) => applicationDbContext.Car.FirstOrDefault(p=> p.id==carId);
    }
}
