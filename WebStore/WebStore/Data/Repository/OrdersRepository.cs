using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Model;

namespace WebStore.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly WebStoreCart webStoreCart;

        public OrdersRepository(ApplicationDbContext applicationDbContext, WebStoreCart webStoreCart) {
            this.applicationDbContext = applicationDbContext;
            this.webStoreCart = webStoreCart;
        }
        public void createOreder(Order order){
            order.orderTime = DateTime.Now;
            applicationDbContext.Order.Add(order);
            applicationDbContext.SaveChanges();

            var items = webStoreCart.listWebStoreItem;

            foreach (var element in items ){
                var orderDetail = new OrderDetail() {
                    CarId = element.car.id,
                    orderID = order.id,
                    price = element.car.price

                };
                applicationDbContext.OrderDetail.Add(orderDetail);
            }
            applicationDbContext.SaveChanges();
        }
    }
}
