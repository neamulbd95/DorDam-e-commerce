using DorDam_ENTITY;
using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class BuyingConfimationController : Controller
    {
        //
        // GET: /BuyingConfimation/

        public ActionResult Index()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];

            iCart_Service cart = Service_Center.GetCart_Service();
            iProduct_Service productAll = Service_Center.GetProduct_Service();//
            iBuying_History_Service buyingHistory = Service_Center.GetBuying_History_Service();
            iProduct_Report_Service report = Service_Center.GetProduct_Report_Service();

            IEnumerable<Cart> FullCart = cart.Get(Session["userName"].ToString());
            
            foreach(Cart c in FullCart)
            {
                Product pro = new Product();
                IEnumerable<Product> proAll = productAll.GetAllValues();

                foreach(Product p in proAll)
                {
                    if(p.Id== c.ProductID)
                    {
                        int before = productAll.Get(p.Id).Product_Quantity;
                        int after = before - c.BuyingQuantity;

                        pro.Id = p.Id;
                        pro.Product_Quantity = after;

                        int y = productAll.Update(pro);
                    }
                }

                Buying_History buy = new Buying_History();
                Product_Report rep = new Product_Report();

                buy.Product_ID = c.ProductID;
                buy.User_Name = Session["userName"].ToString();
                buy.Buying_Quantity = c.BuyingQuantity;
                buy.Buying_Date = DateTime.Now.ToLocalTime();

                IEnumerable<Product_Report> proReport = report.GetAllValues();
                bool check = false;
                int productID=0;

                foreach(Product_Report r in proReport)
                {
                    if(r.Product_ID == c.ProductID)
                    {
                        check = true;
                        productID = r.Product_ID;
                        break;
                    }
                }

                if(check == true)
                {
                    int beforeQuantity = report.Get(productID).Selling_Quantity;
                    int afterQuantity = beforeQuantity + c.BuyingQuantity;

                    rep.Product_ID = productID;
                    rep.Selling_Quantity = afterQuantity;

                    int p = report.Update(rep);
                }
                else
                {
                    rep.Product_ID = c.ProductID;
                    rep.Selling_Quantity = c.BuyingQuantity;

                    int j = report.Insert(rep);
                }

                int i = buyingHistory.Insert(buy);
               
            }



            int de = cart.DeleteUserCart(Session["userName"].ToString());
                //ViewBag.row = cartRow;
            return View();
        }

    }
}
