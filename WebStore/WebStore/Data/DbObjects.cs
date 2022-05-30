using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Model;

namespace WebStore.Data
{
    public class DbObjects{
        public static void Initial(ApplicationDbContext context){
            
            if (!context.Category.Any()){
                context.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Car.Any())
            {
                context.AddRange(
                     new Car
                     {
                         name = "Tesla Model S",
                         shortDesc = "Interior of the Future",
                         longDesc = "Model S platforms unite powertrain and battery technologies for unrivaled performance, range and efficiency. New module and pack thermal architecture allows faster charging and gives you more power and endurance in all conditions.",
                         img = "/img/modelS.jpg",
                         price = 60000,
                         isFavorite = true,
                         avalible = true,
                         Category = Categories["Electric car"],
                     },
                    new Car
                    {
                        name = "Tesla Cybertruck",
                        shortDesc = "If there was something better, we’d use it. ",
                        longDesc = "Cybertruck is built with an exterior shell made for ultimate durability and passenger protection. Starting with a nearly impenetrable exoskeleton, every component is designed for superior strength and endurance, from Ultra-Hard 30X Cold-Rolled stainless-steel structural skin to Tesla armor glass.",
                        img = "/img/cybertruck.jpg",
                        price = 40000,
                        isFavorite = false,
                        avalible = false,
                        Category = Categories["Electric car"],
                    },
                    new Car
                    {
                        name = "Porsche Taycan",
                        shortDesc = "The Taycan is the pure expression of a Porsche electric sports car. ",
                        longDesc = "Striking proportions, timeless and instantly recognisable design, and a perfect blend of performance with everyday usability.",
                        img = "/img/porscheTaycan.jpg",
                        price = 65000,
                        isFavorite = false,
                        avalible = true,
                        Category = Categories["Electric car"],
                    },
                    new Car
                    {
                        name = "Honda Civic",
                        shortDesc = "The Power of Dreams. ",
                        longDesc = "The all Civic Sedan is a modern expression of Honda’s human-centered design philosophy.The Civic ran away with this comparison. It outclasses the Corolla in almost every way we can think of.",
                        img = "/img/hondaCivic.jpg",
                        price = 22000,
                        isFavorite = true,
                        avalible = true,
                        Category = Categories["Car"],
                    },
                    new Car
                    {
                        name = "Tayota corolla",
                        shortDesc = "Strive for the best. ",
                        longDesc = "Modern and prestigious appearance, refined handling and equipment unparalleled in the segment - Toyota Corolla is ideal for dynamic movement on the road to success.",
                        img = "/img/toyotaCorolla.jpg",
                        price = 20000,
                        isFavorite = false,
                        avalible = true,
                        Category = Categories["Car"],
                    },
                    new Car
                    {
                        name = "Volkswagen Polo",
                        shortDesc = "Das Auto. ",
                        longDesc = "The appearance of the Volkswagen Polo is distinguished by an upgraded grille, a new front bumper, a rear diffuser, as well as a completely updated LED optics.",
                        img = "/img/volkswagenPolo.jpg",
                        price = 19000,
                        isFavorite = false,
                        avalible = true,
                        Category = Categories["Car"],
                    }
                );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories{
            get{
                if(category == null) {
                    var list = new Category[]
                    {
                      new Category{categoryName = "Electric car", desc ="Modern mode of transport" },
                      new Category{categoryName = "Car", desc ="Сar with an internal combustion engine" },
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                    
                }
                return category;
            }
        }
    }
}
