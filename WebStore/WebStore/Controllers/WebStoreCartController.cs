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
    public class WebStoreCartController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly WebStoreCart _webStoreCart;

        public WebStoreCartController(IAllCars carRep, WebStoreCart webStoreCart) {
            _carRep = carRep;
            _webStoreCart = webStoreCart;
        }

        public ViewResult Index(){
            var items = _webStoreCart.getWebStoreItem();
            _webStoreCart.listWebStoreItem = items;
            var obj = new WebStoreCartViewModel{
                webStoreCart = _webStoreCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id){
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if (item != null){
                _webStoreCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
