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
    public class AdminReportController : Controller
    {
        //
        // GET: /AdminReport/
        iProduct_Report_Service Report = Service_Center.GetProduct_Report_Service();
        iProduct_Service product = Service_Center.GetProduct_Service();
        iCategory_Service category = Service_Center.GetCategory_Service();
        iSub_Category_Service subCategory = Service_Center.GetSub_Category_Service();

        public ActionResult Index()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];

            Product_Report re = Report.report();
            ReportDetails reDetails = new ReportDetails();

            reDetails.productName = product.Get(re.Product_ID).Product_Name;
            reDetails.category = category.Get(product.Get(re.Product_ID).Category_ID).Category_Name;
            reDetails.subCategory = subCategory.Get(product.Get(re.Product_ID).Sub_Category_ID).Sub_Category_Name;
            reDetails.productPicture = product.Get(re.Product_ID).Product_Picture;
            reDetails.productPrice = product.Get(re.Product_ID).Product_Price;
            reDetails.totalSellingQuantity = re.Selling_Quantity;

            int summation = 0, x=0;
            IEnumerable<Product_Report> reportList = Report.GetAllValues();

            foreach(Product_Report r in reportList)
            {
                x = product.Get(r.Product_ID).Product_Price * r.Selling_Quantity;
                summation += x;
            }
            ViewBag.totalSellingPrice = summation;

            return View(reDetails);
        }


    }
}
