using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebStore.Data.Model
{
    public class WebStoreCart

    {
        private readonly ApplicationDbContext applicationDbContext;

        public WebStoreCart(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }
        public string WebStoreCartId { get; set; }
        public List<WebStoreCarItem> listWebStoreItem { get; set; }

        public static WebStoreCart GetCart( IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDbContext>();
            string webStoreCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", webStoreCartId);
            return new WebStoreCart(context) { WebStoreCartId = webStoreCartId };
        }

        public void AddToCart(Car car) {
            applicationDbContext.WebStoreCarItems.Add(new WebStoreCarItem{
                WebStoreCartId = WebStoreCartId,
                car = car,
                price = car.price,
            });

            applicationDbContext.SaveChanges();

        }

        public List<WebStoreCarItem> getWebStoreItem()
        {
            
            return applicationDbContext.WebStoreCarItems.Where(c => c.WebStoreCartId == WebStoreCartId ).Include(s=>s.car).ToList();
        }
    }
}
