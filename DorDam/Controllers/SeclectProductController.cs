using DorDam_ENTITY;
using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class SeclectProductController : Controller
    {
        // GET: /Category/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SelectItem(int productID)
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            //ViewBag.id = productID;
            iProduct_Service product = Service_Center.GetProduct_Service();

            int catid = product.Get(productID).Category_ID;
            int subcatid = product.Get(productID).Sub_Category_ID;

            iCategory_Service cat = Service_Center.GetCategory_Service();
            iSub_Category_Service sub = Service_Center.GetSub_Category_Service();

            ViewBag.categoryName = cat.Get(catid).Category_Name;
            ViewBag.subcategoryName = sub.Get(subcatid).Sub_Category_Name;
            ViewBag.productPicture = Url.Content(product.Get(productID).Product_Picture);

            Session["SelectItemDetails"] = productID;

            if (product.Get(productID).Product_Quantity > 5)
            {
                ViewBag.productStatus = "In Stock";
            }
            else
            {
                ViewBag.productStatus = "Out of Stock";
            }

            return View(product.Get(productID));
        }

        [HttpPost]
        public ActionResult AddingToCart() 
        {
            if (Convert.ToBoolean(Session["LoggedIN"]) == true)
            {
                iCart_Service cartService = Service_Center.GetCart_Service();
                iProduct_Service product = Service_Center.GetProduct_Service();
                iCategory_Service cat = Service_Center.GetCategory_Service();
                iSub_Category_Service sub = Service_Center.GetSub_Category_Service();

                int productID = Convert.ToInt32(Session["SelectItemDetails"]);
                int catid = product.Get(productID).Category_ID;
                int subcatid = product.Get(productID).Sub_Category_ID;

                Cart cart = new Cart();

                cart.ProductID = productID;
                cart.ProductName = product.Get(productID).Product_Name;
                cart.ProductCategory = cat.Get(catid).Category_Name;
                cart.ProductSubCategory = sub.Get(subcatid).Sub_Category_Name;
                cart.ProductPicture = product.Get(productID).Product_Picture;
                cart.ProductPrice = product.Get(productID).Product_Price;
                cart.BuyingQuantity = Convert.ToInt32(Request.Form["quantityItem"]);
                cart.Username = Session["userName"].ToString();

                int i = cartService.Insert(cart);

                if (i == 1)
                {
                    return RedirectToAction("Index", "Cart");
                }

                else
                {
                    return RedirectToAction("Index", "Home");
                }            
            }
            else
            {
                return RedirectToAction("Index", "userAuthentication");
            }

        }

        public void Edit() 
        {
            
        }

    }
}
