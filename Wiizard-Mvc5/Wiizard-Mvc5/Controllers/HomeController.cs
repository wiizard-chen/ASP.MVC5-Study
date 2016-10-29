using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wiizard_Mvc5.Models;
namespace Wiizard_Mvc5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "good Morning" : "good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse gurstResponse)
        {
            if (ModelState.IsValid)
                return View("thanks", gurstResponse);
            else
                return View();
        }
    }
}