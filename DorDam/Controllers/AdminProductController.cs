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
    public class AdminProductController : Controller
    {
        //
        // GET: /AdminProduct/
        iProduct_Service product = Service_Center.GetProduct_Service();
        iCategory_Service category = Service_Center.GetCategory_Service();
        iSub_Category_Service subCategory = Service_Center.GetSub_Category_Service();

        public ActionResult Index()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            //IEnumerable<Category> catlist = category.GetAllValues();
            return View(category.GetAllValues());
        }

        public ActionResult showProduct()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            if (Request.Form["submitButton"] != null)
            {
                ViewBag.CategoryName = category.Get(Convert.ToInt32(Request.Form["categoryDropDown"])).Category_Name;
                IEnumerable<Product> pro = product.GetByCategory(Convert.ToInt32(Request.Form["categoryDropDown"]));
                List<ProductCategory> proFullList = new List<ProductCategory>();

                foreach (Product p in pro)
                {
                    ProductCategory proFull = new ProductCategory();
                    proFull.productID = p.Id;
                    proFull.productName = p.Product_Name;
                    proFull.productCategoryName = category.Get(Convert.ToInt32(Request.Form["categoryDropDown"])).Category_Name;
                    proFull.productSubCategoryName = subCategory.Get(p.Sub_Category_ID).Sub_Category_Name;
                    proFull.productPrice = p.Product_Price;
                    proFull.productQuantity = p.Product_Quantity;
                    proFull.productPicture = p.Product_Picture;
                    proFull.productAbout = p.Product_About;

                    proFullList.Add(proFull);
                }
                ViewBag.check = Request.Form["categoryDropDown"];
                return View(proFullList);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            ViewBag.productName = product.Get(id).Product_Name;
            return View(product.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            int update = product.Update(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            int delete = product.Delete(id);
            return View("Index","Admin");
        }

        //Add Product
        public ActionResult addCategory()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            return View(category.GetAllValues());
        }

        public ActionResult addSubCategory()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            Session["CategoryForAddProduct"] = Request.Form["categoryDropDown"];
            return View(subCategory.GetList(Convert.ToInt32(Request.Form["categoryDropDown"])));
        }

        public ActionResult redirect()
        {
            //subCategoryDropDown
            Session["SubCategoryForAddProduct"] = Request.Form["subCategoryDropDown"];
            return RedirectToAction("");
        }

        public ActionResult AddProduct() 
        {
            if (Request.Form["submitButton"] != null)
            {
                Product pro = new Product();

                pro.Product_Name = Request.Form["nametxt"];
                pro.Category_ID = Convert.ToInt32(Session["CategoryForAddProduct"]);
                pro.Sub_Category_ID = Convert.ToInt32(Request.Form["subCategoryDropDown"]);
                pro.Product_Price = Convert.ToInt32(Request.Form["pricetxt"]);
                pro.Product_Quantity = Convert.ToInt32(Request.Form["quantitytxt"]);
                pro.Product_Picture = Request.Form["picturetxt"];
                pro.Product_About = Request.Form["abouttxt"];

                int insert = product.Insert(pro);
                return RedirectToAction("Index","Admin");

            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

    }
}
