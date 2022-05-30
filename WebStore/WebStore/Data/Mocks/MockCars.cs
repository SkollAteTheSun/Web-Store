using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Model;

namespace WebStore.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> {
                    new Car { 
                        name = "Tesla Model S", 
                        shortDesc = "Interior of the Future", 
                        longDesc = "Model S platforms unite powertrain and battery technologies for unrivaled performance, range and efficiency. New module and pack thermal architecture allows faster charging and gives you more power and endurance in all conditions.", 
                        img = "/img/modelS.png", 
                        price = 60000, 
                        isFavorite = true, 
                        avalible = true, 
                        Category = _categoryCars.AllCategories.First() 
                    },
                    new Car {
                        name = "Tesla Cybertruck",
                        shortDesc = "If there was something better, we’d use it. ",
                        longDesc = "Cybertruck is built with an exterior shell made for ultimate durability and passenger protection. Starting with a nearly impenetrable exoskeleton, every component is designed for superior strength and endurance, from Ultra-Hard 30X Cold-Rolled stainless-steel structural skin to Tesla armor glass.",
                        img = "/img/cybertruck.jpg",
                        price = 40000,
                        isFavorite = false,
                        avalible = false,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Porsche Taycan",
                        shortDesc = "The Taycan is the pure expression of a Porsche electric sports car. ",
                        longDesc = "Striking proportions, timeless and instantly recognisable design, and a perfect blend of performance with everyday usability.",
                        img = "/img/porscheTaycan.jpg",
                        price = 65000,
                        isFavorite = false,
                        avalible = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Honda Civic",
                        shortDesc = "The Power of Dreams. ",
                        longDesc = "The all Civic Sedan is a modern expression of Honda’s human-centered design philosophy.The Civic ran away with this comparison. It outclasses the Corolla in almost every way we can think of.",
                        img = "/img/hondaCivic.jpg",
                        price = 22000,
                        isFavorite = true,
                        avalible = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Tayota corolla",
                        shortDesc = "Strive for the best. ",
                        longDesc = "Modern and prestigious appearance, refined handling and equipment unparalleled in the segment - Toyota Corolla is ideal for dynamic movement on the road to success.",
                        img = "/img/toyotaCorolla.jpg",
                        price = 20000,
                        isFavorite = false,
                        avalible = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Volkswagen Polo",
                        shortDesc = "Das Auto. ",
                        longDesc = "The appearance of the Volkswagen Polo is distinguished by an upgraded grille, a new front bumper, a rear diffuser, as well as a completely updated LED optics.",
                        img = "/img/volkswagenPolo.jpg",
                        price = 19000,
                        isFavorite = false,
                        avalible = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
