using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data.Model
{
    public class WebStoreCarItem
    {
        public int id { get; set; }
        public Car car { get; set; }
        public int price { get; set; }
        public string WebStoreCartId { get; set; }
    }
}
