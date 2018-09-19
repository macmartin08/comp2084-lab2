using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string ProductName)
        {
            ViewBag.ProductName = "You Selected Product: " +ProductName;
            return View();
        }
    }
}