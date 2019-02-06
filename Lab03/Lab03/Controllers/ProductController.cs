using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public string Index()
        {
            return "Product/Index is displayed.";
        }
        public string Browse()
        {
            return "Browse displayed";
        }
        public string Details(int id)
        {
            return "Details displayed for id=" + id;
        }
        public string Location(string zip)
        {
            return HttpUtility.HtmlEncode("Location display for zip=" + zip);
        }
    }
}