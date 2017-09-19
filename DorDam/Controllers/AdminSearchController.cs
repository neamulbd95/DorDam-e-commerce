using DorDam_ENTITY;
using DorDam_SERVICE;
using DorDam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class AdminSearchController : Controller
    {
        //
        // GET: /AdminSearch/
        iProduct_Service product = Service_Center.GetProduct_Service();

        public ActionResult Index()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            string search = Request.Form["nameSearch"];

            return View(product.SearchProduct(search));
        }
        [HttpPost] 
        public JsonResult LiveSearch(string Prefix)
        {
            //product.SearchProduct(search)
            IEnumerable<Product> searchList = product.SearchProduct(Prefix);

            List<Search> search = new List<Search>();

            foreach(Product p in searchList)
            {
                Search s = new Search();
                s.productName = p.Product_Name;

                search.Add(s);
            }

            return Json(search, JsonRequestBehavior.AllowGet); 
        }
       
    }
}
