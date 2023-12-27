using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JulieInventoryMVC.Models;
using JulieInventoryMVC_Models.ItemMaster;
using JulieInventoryMVC_Services.TItemMaster;
using PagedList;

namespace JulieInventoryMVC.Controllers
{
    public class TailoringItemsController : Controller
    {
        ITItemMasterServices _dc = new TItemMasterServices();
        // GET: TailoringStitchingItems
        public ActionResult Index(int page = 1, int pageSize = 20)
        {
            if (Session["UserId"] != null)
            {
                int totalCount;
                var dataList = _dc.GetTItemMaster();

                var ItemMaster = dataList.ToPagedList(page, pageSize);


                int pageIndex = 1;
                pageIndex = page != 0 ? Convert.ToInt32(page) : 1;
                int defaSize = pageSize == 0 ? 20 : pageSize;
                ViewBag.psize = defaSize;
                ViewBag.PageSize = new List<SelectListItem>()
                    {
                        new SelectListItem() { Value="5", Text= "5" },
                        new SelectListItem() { Value="10", Text= "10" },
                        new SelectListItem() { Value="15", Text= "15" },
                        new SelectListItem() { Value="25", Text= "25" },
                        new SelectListItem() { Value="50", Text= "50" },
                     };

                IPagedList<TItemMaster> involst = null;

                involst = ItemMaster.ToPagedList(pageIndex, defaSize);

                return View(involst);
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }


        public ActionResult Create()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }
        [HttpPost]
        public ActionResult Create(ItemMasterVM data)
        {
            data.itemMasterJson.Sys_Time = DateTime.Now;
            data.itemMasterJson.CurrUsr = Request["UserName"];
            var insert = _dc.AddItemMaster(data.itemMasterJson);
            var para = _dc.AddItemParameter(data.Parameters, insert);
            var notes = _dc.AddItemNotesStyles(data.NotesStyles, insert);
            return RedirectToAction("Index", "TailoringItems");
        }

        public ActionResult Delete(int id)
        {
            var dataList = _dc.DeleteItemMaster(id);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var result = _dc.GetItemMaster(id);
            return View(result);
        }
        public ActionResult Edit(int id)
        {
            var result = _dc.GetItemMaster(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(ItemMasterVM data)
        {
            data.itemMasterJson.Sys_Time = DateTime.Now;
            data.itemMasterJson.CurrUsr = Request["UserName"];
            var insert = _dc.AddItemMaster(data.itemMasterJson);
            int par = data.Parameters.Where(x => x.ParaId == 0).Count();
            int not = data.NotesStyles.Where(x => x.ParaId == 0).Count();
            if (par != 0) {
              _dc.AddItemParameter(data.Parameters.Where(x=>x.ParaId==0).ToList(), insert);
            }
            if (not != 0) {
              _dc.AddItemNotesStyles(data.NotesStyles.Where(x=>x.ParaId==0).ToList(), insert);
            }
            var para = _dc.UpdateItemParameter(data.Parameters.Where(x => x.ParaId != 0).ToList());
            var notes = _dc.UpdateItemNotesStyles(data.NotesStyles.Where(x => x.ParaId != 0).ToList());
            return RedirectToAction("Index", "TailoringItems");
        }

    }
}