using JulieInventoryMVC.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulieInventoryMVC.Controllers
{
    [SessionExpire(true)]
    public class EmployeeMasterController : Controller
    {
        // GET: EmployeeMaster
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}