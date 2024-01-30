using JulieInventoryMVC.App_Start;
using JulieInventoryMVC_Models.OrderInvoiceMaster;
using JulieInventoryMVC_Services.OrderInvoice;
using JulieInventoryMVC_Services.TItemMaster;
using PagedList;
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
        IOrderInvoiceServices db = new OrderInvoiceServices();

        // GET: OrderInvoice
        public ActionResult Index(int? page)
        {
            if (Session["UserId"] != null)
            {
                int pageSize = 20;
                int pageNumber = (page ?? 1);
                var dataList = db.GetInvoiceMasters(Convert.ToInt32(Session["CId"])).OrderByDescending(x => x.InvId);
                var ItemMaster = dataList.ToPagedList(pageNumber, pageSize);

                return View(ItemMaster);
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }
        public ActionResult Create()
        {
            ViewBag.Mesurement = db.GetMesurements(Convert.ToInt32(Session["CId"]));
            ViewBag.SalesMan = db.GetSalesMan(Convert.ToInt32(Session["CId"]));
            ViewBag.InvoiceNo = db.GetinvoiceNO();
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }

        public JsonResult GetItemNameList(int leadId)
        {
            var list = db.GetItemName(Convert.ToInt32(Session["CId"]), leadId);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetItemNameDetails(int leadId,int iid)
        {
            var list = db.GetItemName(Convert.ToInt32(Session["CId"]), leadId).Where(x=>x.TItemId==iid);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}