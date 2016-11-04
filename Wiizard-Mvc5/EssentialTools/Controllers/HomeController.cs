using EssentialTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products =
        {
            new Product {Name = "kayak", Category="watersports",Price=275M },
            new Product {Name = "lifejacket", Category="watersports",Price=48.95M },
            new Product {Name = "soccer ball", Category="soccer",Price=19.50M },
            new Product {Name = "corner flag", Category="watersports",Price=34.95M }
        };

        // GET: Home
        public ActionResult Index()
        {
            LinqValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc);
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}