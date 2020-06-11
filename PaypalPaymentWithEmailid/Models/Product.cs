using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaypalPaymentWithEmailid.Models
{
    public class Product
    {
        [Required]
        public string Price { get; set; }
    }
}