using JulieInventoryMVC.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulieInventoryMVC.Controllers
{
    [SessionExpire(true)]
    public class OrderInvoiceController : Controller
    {
        // GET: OrderInvoice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}