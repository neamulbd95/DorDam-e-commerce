using DorDam_ENTITY;
using DorDam_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DorDam.Controllers
{
    public class AdminUserController : Controller
    {
        //
        // GET: /AdminUser/
        iUser_Info_Service userInfo = Service_Center.GetUser_Info_Service();
        iLog_in_Service log = Service_Center.GetLog_in_Service();

        public ActionResult Index()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.logged = Session["LoggedIN"];
            return View(userInfo.GetAllValues());
        }

        public ActionResult DeleteUser(int id)
        {
            string username = userInfo.GetUserName(id).User_name;

            int delete = userInfo.Delete(id);
            int logdelete = log.Delete(username);

            return RedirectToAction("Index");
        }
    }
}
