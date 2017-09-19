using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        iProduct_Service pro = Service_Center.GetProduct_Service();

        public ActionResult Index()
        {

            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];

            ViewBag.menID = pro.GetLastItem(1).Id;
            ViewBag.menName = pro.GetLastItem(1).Product_Name;
            ViewBag.menPic = Url.Content(pro.GetLastItem(1).Product_Picture);

            ViewBag.womenID = pro.GetLastItem(2).Id;
            ViewBag.womenName = pro.GetLastItem(2).Product_Name;
            ViewBag.womenPic = Url.Content(pro.GetLastItem(2).Product_Picture);

            ViewBag.phoneID = pro.GetLastItem(3).Id;
            ViewBag.phoneName = pro.GetLastItem(3).Product_Name;
            ViewBag.phonePic = Url.Content(pro.GetLastItem(3).Product_Picture);

            ViewBag.electroinicID = pro.GetLastItem(4).Id;
            ViewBag.electronicName = pro.GetLastItem(4).Product_Name;
            ViewBag.electronicPic = Url.Content(pro.GetLastItem(4).Product_Picture);

            ViewBag.laptopID = pro.GetLastItem(5).Id;
            ViewBag.laptopName = pro.GetLastItem(5).Product_Name;
            ViewBag.laptopPic = Url.Content(pro.GetLastItem(5).Product_Picture);

            ViewBag.sportsID = pro.GetLastItem(6).Id;
            ViewBag.sportsName = pro.GetLastItem(6).Product_Name;
            ViewBag.sportsPic = Url.Content(pro.GetLastItem(6).Product_Picture);

            return View();
        }

    }
}
