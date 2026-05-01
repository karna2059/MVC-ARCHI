using MVC_ARCHI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ARCHI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int productid = 1;
            string name = "apple";
            string quantity = "10";
            decimal price = 100.00m;
            bool status = true;

            ViewBag.productid = productid;
            ViewBag.name = name;
            ViewBag.quantity = quantity;
            ViewBag.price = price;
            ViewBag.status = status;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult productdetails()
        {
            productdetails objpro = new productdetails()
            {
               id=1,
               name="dell",
               description= "this is product details"
            };
            ViewData["data"] = "welcome";


            int productid = 1;
            string name = "apple";
            string quantity = "10";
            decimal price = 100.00m;
            bool status = true;
            ViewData["productid"] = productid;
            ViewData["name"] = name;
            ViewData["quantity"] = quantity;
            ViewData["price"] = price;
            ViewData["status"] = status;



            return View(objpro);
        }
        public ActionResult Redirect()
        {
            ViewBag.Message = "this is viewbag message";
            ViewData["Message"] = "this is viewdata message";
            TempData["data"] = "this is tempdata message";
            Session["data"] = "this is session message";

            return RedirectToAction("success");

        }
        public ActionResult success()
        {
            return View();
        }
    }
}