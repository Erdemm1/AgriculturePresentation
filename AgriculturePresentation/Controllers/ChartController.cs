using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> products = new List<ProductClass>();

            products.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 850
            });
            products.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 440
            });
            products.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 380
            });
            products.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 620
            });
            products.Add(new ProductClass
            {
                productname = "Yulaf",
                productvalue = 700
            });
            return Json(new {jsonlist=products});
        }
    }
}
