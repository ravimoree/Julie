using JulieInventoryMVC.App_Start;
using JulieInventoryMVC_Services.WorkerItemRate;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulieInventoryMVC.Controllers
{
    [SessionExpire(true)]
    public class ItemWiseRateChartController : Controller
    {
        IWorkerItemWiseRateServices db = new WorkerItemWiseRateServices();
        // GET: ItemWiseRateChart
        public ActionResult Index(int? page)
        {
            if (Session["UserId"] != null)
            {
                int pageSize = 20;
                int pageNumber = (page ?? 1);
                var dataList = db.GetWorkerItemWiseRates();
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
            var List=db.GetView();
            ViewBag.Worker = List.workerRateWorker.ToList();
            ViewBag.ItemName = List.workerRateItemNames.ToList();
            ViewBag.WorkName = List.workerRateWorkName.ToList();
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