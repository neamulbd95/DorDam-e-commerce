using DorDam_ENTITY;
using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class UserProfileController : Controller
    {
        //
        // GET: /UserProfile/
        iUser_Info_Service user = Service_Center.GetUser_Info_Service();
        public ActionResult Index()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];

            return View(user.Get(Session["userName"].ToString()));
        }

        [HttpGet]
        public ActionResult Create()
        {
            @ViewBag.errMsg = Session["signUPerrmsg"];
            return View();
        }

        [HttpPost]
        public ActionResult CreateAfter()
        {
            iLog_in_Service logNew = Service_Center.GetLog_in_Service();

            User_Info uNew = new User_Info();
            Log_in lnew = new Log_in();

            if (Request.Form["signUP"] != null)
            {
                if (Request.Form["passtxt"] == Request.Form["rePasstxt"])
                {
                    uNew.User_name = Request.Form["usernametxt"];
                    uNew.User_Full_name = Request.Form["fullnametxt"];
                    uNew.User_Email = Request.Form["emailtxt"];
                    uNew.User_Mobile = Request.Form["mobiletxt"];
                    uNew.User_Gender = Request.Form["genderSelect"];
                    uNew.User_DateOfBirth = Convert.ToDateTime(Request.Form["DOB"]);

                    lnew.User_Name = Request.Form["usernametxt"];
                    lnew.Password = Request.Form["passtxt"];

                    int i = user.Insert(uNew);
                    int j = logNew.Insert(lnew);

                    return RedirectToAction("Index", "userAuthentication");
                }
                else
                {
                    Session["signUPerrmsg"] = "Password Not matched";
                    return RedirectToAction("Create");
                }
            }
            else
            {
                return View();
            }       
        }

        public ActionResult Edit()
        {
            return View(user.Get(Session["userName"].ToString()));
        }

        public ActionResult EditConfirmation()
        {
            User_Info uI = new User_Info();
            if (Request.Form["editCon"] != null)
            {
                uI.User_name = Session["userName"].ToString();
                uI.User_Full_name = Request.Form["fullnametxt"];
                uI.User_Mobile = Request.Form["mobiletxt"];

                int i = user.Update(uI);
            }
           
            return RedirectToAction("Index");
        }

    }
}
