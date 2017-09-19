using DorDam_ENTITY;
using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/

        public ActionResult Index()
        {
            if (Convert.ToBoolean(Session["LoggedIN"]) == true)
            {
                ViewBag.userName = Session["userName"];
                ViewBag.logged = Session["LoggedIN"];

                iCart_Service cart = Service_Center.GetCart_Service();

                int totalSum = 0;

                IEnumerable<Cart> CartAll = cart.Get(Session["userName"].ToString());

                foreach (Cart c in CartAll)
                {
                    int sum = c.BuyingQuantity * c.ProductPrice;
                    totalSum += sum;
                }

                ViewBag.totalPrice = totalSum;
                return View(cart.Get(Session["userName"].ToString()));
            }
            else
            {
                return RedirectToAction("Index", "userAuthentication");
            }
        }

        public ActionResult Delete(int id) 
        {
            iCart_Service cart = Service_Center.GetCart_Service();

            int i = cart.DeleteItem(id);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateIncreaseOne(int id)
        {
            iCart_Service cart = Service_Center.GetCart_Service();
            Cart c = new Cart();

            c.Id = id;
            c.BuyingQuantity = cart.GetbyID(id).BuyingQuantity + 1;

            int i = cart.Update(c);

            return RedirectToAction("Index");
        }

        public ActionResult UpdateDecresceOne(int id)
        {
            iCart_Service cart = Service_Center.GetCart_Service();
            Cart c = new Cart();

            if (cart.GetbyID(id).BuyingQuantity > 1) 
            {
                c.Id = id;
                c.BuyingQuantity = cart.GetbyID(id).BuyingQuantity - 1;
                int i = cart.Update(c);
                return RedirectToAction("Index");
            }
            else
            {
                int i = cart.DeleteItem(id);
                return RedirectToAction("Index");
            }
                        
        }

        public ActionResult fullCartDelete()
        {
            iCart_Service cart = Service_Center.GetCart_Service();

            int de = cart.DeleteUserCart(Session["userName"].ToString());

            return RedirectToAction("Index", "Home");
        }
    }
}
