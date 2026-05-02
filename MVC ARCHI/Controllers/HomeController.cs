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
                id = 1,
                name = "dell",
                description = "this is product details"
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

        public ActionResult Details()
        {

            student objs = new student()
            {
                studentid = 1,
                name = "karna",
                age = 22,
                email = "karna@gmail.com",
                EnrollmentDate = new DateTime(2020, 01, 01)
            };
            return View(objs);

        }
        public ActionResult liststudent()
        {
            List<student> objstu = new List<student>()
            {
                new student() { studentid=101, name="karna", age=22, email="karna@gmail.com", EnrollmentDate = new DateTime(2020, 01, 01) },
                new student() { studentid=102, name="sita", age=21, email="sita@gmail.com", EnrollmentDate = new DateTime(2021, 02, 01) },
                new student() { studentid=103, name="ram", age=23, email="ram@gmail.com", EnrollmentDate = new DateTime(2022, 03, 01) },
                new student() { studentid=104, name="lakshman", age=24, email="lakshman@gmail.com", EnrollmentDate = new DateTime(2023, 04, 01) },
                new student() { studentid=105, name="hanuman", age=25, email="hanuman@gmail.com", EnrollmentDate = new DateTime(2024, 05, 01) }

            };
            return View(objstu);

        }
        public ActionResult listorder()
        {
            List<order> objord = new List<order>()
            {
                new order() { orderid=1, name="karna", address="delhi" },
                new order() { orderid=2, name="sita", address="mumbai" },
                new order() { orderid=3, name="ram", address="chennai" },
                new order() { orderid=4, name="lakshman", address="kolkata" },
                new order() { orderid=5, name="hanuman", address="bangalore" }
            };
            return View(objord);
        }

        public ActionResult employeedetails()
        {
            List<employeedetails> objemp = new List<employeedetails>()
            {
                new employeedetails() { empoyeeid=1, name="karna", phone=1234567890, email="karna@gmail.com", salary=50000 },
                new employeedetails() { empoyeeid=2, name="sita", phone=9876543210, email="sita@gmail.com", salary=60000 },
                new employeedetails() { empoyeeid=3, name="ram", phone=4567891230, email="ram@gmail.com", salary=55000 },
                new employeedetails() { empoyeeid=4, name="lakshman", phone=7891234560, email="lakshman@gmail.com", salary=70000 },
                new employeedetails() { empoyeeid=5, name="hanuman", phone=3216549870, email="hanuman@gmail.com", salary=65000 }
            };
            return View(objemp);
        }

       
    }
}