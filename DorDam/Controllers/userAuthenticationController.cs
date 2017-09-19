using DorDam_ENTITY;
using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DorDam.Controllers
{
    public class userAuthenticationController : Controller
    {
        //
        // GET: /userAuthentication/
        iLog_in_Service log = Service_Center.GetLog_in_Service();
        public ActionResult Index()
        {
            if (Session["userName"]==null)
            {
                @ViewBag.ErrorMsg = Session["errormsg"];
                return View();
            }
            else
            {                
                return RedirectToAction("accessDenied");
            }
        }

        public ActionResult accessDenied()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            return View();
        }

        public ActionResult checkLogin()
        {
            string username = Request.Form["username"];
            string password = Request.Form["pass"];

            Log_in logIN = new Log_in();

            if(log.Get(username,password)==null)
            {
                Session["errormsg"] = "Log In Falied. Check UserName Or Password";
                return RedirectToAction("Index");
                //return View();
            }
            else
            {
                if(username == "admin")
                {
                    return RedirectToAction("Index","Admin");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(username, true);
                    Session["userName"] = username;
                    Session["LoggedIN"] = true;
                    return RedirectToAction("Index", "Home");
                }                
            } 
        }

        public ActionResult LogOut()
        {
            Session.Clear();

            FormsAuthentication.SignOut();

            return RedirectToAction("Index","Home");
        }
    }
}
