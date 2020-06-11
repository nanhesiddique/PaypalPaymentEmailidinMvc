using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaypalPaymentWithEmailid.Models;

namespace PaypalPaymentWithEmailid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Index(Product pp)
        {
            decimal price = Convert.ToDecimal(pp.Price);

            string returnURL = "";

            returnURL += "https://www.paypal.com/xclick/business=shuklasatyam90@hotmail.com";

            returnURL += "&item_name=" + "Abc";

            string fname = "Nanhe";
            returnURL += "&first_name" + fname;

            string myCity = "Delhi";
            returnURL += "&city" + myCity;

            string myState = "New Delhi";
            returnURL += "&state" + myState;

            returnURL += "&amount=" + price;

            returnURL += "&currency=USD";

            returnURL += "&return=https://localhost:44308/Home/SuccessView";

            returnURL += "&cancel_return=https://localhost:44308/Home/FailureView";

            Response.Redirect(returnURL);

        }
        public ActionResult SuccessView()
        {
            return View();
        }
        public ActionResult FailureView()
        {
            return View();
        }
    }
}