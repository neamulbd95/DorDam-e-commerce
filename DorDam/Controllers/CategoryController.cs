using DorDam_ENTITY;
using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/
        iProduct_Service product = Service_Center.GetProduct_Service();

        public ActionResult Index(int cat)
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];

            iCategory_Service category = Service_Center.GetCategory_Service();

            @ViewBag.CategoryName = category.Get(cat).Category_Name;
            return View(product.GetByCategory(cat));
        }

    }
}
