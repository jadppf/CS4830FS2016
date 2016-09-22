using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RESTHandRolled.Models;

namespace RESTHandRolled.Controllers
{
    public class ProductsController : Controller
    {

        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        // GET: Products
        public ActionResult Index()
        {
            //return View();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Product(int id=(-1))
        {
            if (-1==id)
            {
                return Json(products, JsonRequestBehavior.AllowGet);
            }

            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return (null);
            }

            return Json(product, JsonRequestBehavior.AllowGet);
        }
    }
}