using Microsoft.AspNetCore.Mvc;
using WebStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;

namespace WebStore.Controllers
{
    public class OrderController : Controller{
        private readonly IAllOrders allOrders;
        private readonly WebStoreCart webStoreCart;

        public OrderController(IAllOrders allOrders, WebStoreCart webStoreCart)
        {
            this.allOrders = allOrders;
            this.webStoreCart = webStoreCart;
        }

        public IActionResult Checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            webStoreCart.listWebStoreItem = webStoreCart.getWebStoreItem();
            if(webStoreCart.listWebStoreItem.Count == 0){
                ModelState.AddModelError("", "You must have products");
            }
            

            if(ModelState.IsValid){
                allOrders.createOreder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order successfully processed";
            return View();
        }

    }
}
