using JulieInventoryMVC.App_Start;
using JulieInventoryMVC_Models.WorkerEmployee;
using JulieInventoryMVC_Services.WorkerEmployee;
using PagedList;
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
        IWorkerEmployeeServices db = new WorkerEmployeeServices();
        // GET: EmployeeMaster
        public ActionResult Index(int? page)
        {
            if (Session["UserId"] != null)
            {
                int pageSize = 20;
                int pageNumber = (page ?? 1);
                var dataList = db.GetWorkerEmployees(Convert.ToInt32(Session["CId"]));
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
            List<int> ids = new List<int> { 30, 39, 40, 41, 42 };
            ViewBag.GroupMasters = db.GetGroupMasters().Where(x=> ids.Contains(x.G_Id));
            ViewBag.EmpGrade = db.GetMiscMasters(Convert.ToInt32(Session["CId"])).Where(x=>x.MiscType== "Worker Grade").ToList();
            ViewBag.SalaryType = db.GetMiscMasters(Convert.ToInt32(Session["CId"])).Where(x=>x.MiscType== "Salary Type").ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(WorkerEmployeeVM modal)
        {

            modal.CurrUsr = Request["UserName"];

            var data = db.InsertWorkerEmployee(modal);
            return RedirectToAction("Index", "EmployeeMaster");
        }
        public ActionResult Edit(int id)
        {
            List<int> ids = new List<int> { 30, 39, 40, 41, 42 };
            var dataList = db.GetWorkerEmployees(Convert.ToInt32(Session["CId"])).Where(x=>x.LedgerId==id).FirstOrDefault();
            ViewBag.GroupMasters = db.GetGroupMasters().Where(x => ids.Contains(x.G_Id));
            ViewBag.EmpGrade = db.GetMiscMasters(Convert.ToInt32(Session["CId"])).Where(x => x.MiscType == "Worker Grade").ToList();
            ViewBag.SalaryType = db.GetMiscMasters(Convert.ToInt32(Session["CId"])).Where(x => x.MiscType == "Salary Type").ToList();

            return View(dataList);
        }
        [HttpPost]
        public ActionResult Edit(WorkerEmployeeVM modal)
        {
            var data = db.UpdateWorkerEmployee(modal);
            return RedirectToAction("Index", "EmployeeMaster");
        }
        public ActionResult Details(int id)
        {
            List<int> ids = new List<int> { 30, 39, 40, 41, 42 };
            var dataList = db.GetWorkerEmployees(Convert.ToInt32(Session["CId"])).Where(x => x.LedgerId == id).FirstOrDefault();
            ViewBag.GroupMasters = db.GetGroupMasters().Where(x => ids.Contains(x.G_Id));
            ViewBag.EmpGrade = db.GetMiscMasters(Convert.ToInt32(Session["CId"])).Where(x => x.MiscType == "Worker Grade").ToList();
            ViewBag.SalaryType = db.GetMiscMasters(Convert.ToInt32(Session["CId"])).Where(x => x.MiscType == "Salary Type").ToList();

            return View(dataList);
        }
    }
}