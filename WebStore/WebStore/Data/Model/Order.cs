using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data.Model
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name ="Input name")]
        //[Required(ErrorMessage = "Length at least 2 characters")]
        public string name { get; set; }

        [Display(Name = "Input surname")]
        //[Required(ErrorMessage = "Length at least 5 characters")]
        public string surName { get; set; }

        [Display(Name = "Input adress")]
        //[Required(ErrorMessage = "Length at least 5 characters")]
        public string adress { get; set; }

        [Display(Name = "Input phone")]
        [DataType(DataType.PhoneNumber)]
        //[Required(ErrorMessage = "Length at least 8 characters")]
        public string phone { get; set; }

        [Display(Name = "Input email")]
        [DataType(DataType.EmailAddress)]
        //[Required(ErrorMessage = "Length at least 8 characters")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> OrederDetails { get; set; }
    }
}
