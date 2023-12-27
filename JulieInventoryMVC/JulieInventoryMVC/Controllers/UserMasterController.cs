using JulieInventoryMVC.App_Start;
using JulieInventoryMVC_Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using JulieInventoryMVC_Models.Users;

namespace JulieInventoryMVC.Controllers
{
    [SessionExpire(true)]
    public class UserMasterController : Controller
    {
        IUserServices _users = new UserServices();
        // GET: UserMaster
        public ActionResult Index()
        {
            var session = Request.Cookies["LoginCookie"];
            if (Session["UserId"] != null)
            {
                var data = _users.GetUser(session.Values["UserName"]);

                return View(data);
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }
        [HttpPost]
        public ActionResult Index(UserMaster master)
        {
            var result = _users.AddUser(master);
            if (result!=0) { TempData["message"] = "User profile updated."; } else { TempData["message"] = "User profile not updated"; }
            return RedirectToAction("Index", "UserMaste");
        }
    }
}