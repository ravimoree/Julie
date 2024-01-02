using JulieInventoryMVC_Models.ItemMaster;
using JulieInventoryMVC_Services.TItemMaster;
using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulieInventoryMVC.Controllers
{
    public class TailoringItemsController : Controller
    {
        ITItemMasterServices _dc = new TItemMasterServices();

        public ActionResult Index(int? page)
        {
            if (Session["UserId"] != null)
            {
                int pageSize = 10;
                int pageNumber = (page ?? 1);

                var dataList = _dc.GetTItemMaster();

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
            if (Session["UserId"] != null)
            {
                var cid = Session["CId"].ToString();
                ViewBag.GetMiscMaster = _dc.GetMiscMaster(Convert.ToInt32(cid));
                ViewBag.GetItemGroupMaster = _dc.GetItemGroupMaster();

                return View();
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }
        [HttpPost]
        public ActionResult Creates(string ItemMasterData, string ParametersData, string NotesStylesData)
        {
            var itemMaster = new ItemMasterVM()
            {
                ItemMaster = new TItemMaster(),
                Parameters = new List<ItemParameter>(),
                NotesStyles = new List<ItemNotesStyles>()
            };
            itemMaster.ItemMaster = JsonConvert.DeserializeObject<TItemMaster>(ItemMasterData);
            itemMaster.Parameters = JsonConvert.DeserializeObject<List<ItemParameter>>(ParametersData);
            itemMaster.NotesStyles = JsonConvert.DeserializeObject<List<ItemNotesStyles>>(NotesStylesData);


            if (!string.IsNullOrEmpty(ItemMasterData))
            {
            }
            if (Request.Files.Count > 0)
            {
                HttpFileCollectionBase files = Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    string fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(files[i].FileName);

                    HttpPostedFileBase file = files[i];
                    string path = Path.Combine(Server.MapPath("~/Image/ItemMaster/"), fileName);

                    itemMaster.ItemMaster.ImgPath = "/Image/ItemMaster/" + fileName;
                    file.SaveAs(path);
                }
            }

            itemMaster.ItemMaster.Sys_Time = DateTime.Now;
            itemMaster.ItemMaster.CurrUsr = Request["UserName"];
            var insert = _dc.AddItemMaster(itemMaster.ItemMaster);
            var para = _dc.AddItemParameter(itemMaster.Parameters, insert);
            var notes = _dc.AddItemNotesStyles(itemMaster.NotesStyles, insert);

            return RedirectToAction("Index", "TailoringItems");

        }

        public ActionResult Delete(int id)
        {
            var dataList = _dc.DeleteItemMaster(id);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            if (Session["UserId"] != null)
            {
                var result = _dc.GetItemMaster(id);
                return View(result);
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }
        public ActionResult Edit(int id)
        {
            if (Session["UserId"] != null)
            {
                var result = _dc.GetItemMaster(id);
                return View(result);
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }
        [HttpPost]
        public ActionResult Edit(ItemMasterVM data)
        {
            data.ItemMaster.Sys_Time = DateTime.Now;
            data.ItemMaster.CurrUsr = Request["UserName"];
            var insert = _dc.AddItemMaster(data.ItemMaster);
            int par = data.Parameters.Where(x => x.ParaId == 0).Count();
            int not = data.NotesStyles.Where(x => x.ParaId == 0).Count();
            if (par != 0)
            {
                _dc.AddItemParameter(data.Parameters.Where(x => x.ParaId == 0).ToList(), insert);
            }
            if (not != 0)
            {
                _dc.AddItemNotesStyles(data.NotesStyles.Where(x => x.ParaId == 0).ToList(), insert);
            }
            var para = _dc.UpdateItemParameter(data.Parameters.Where(x => x.ParaId != 0).ToList());
            var notes = _dc.UpdateItemNotesStyles(data.NotesStyles.Where(x => x.ParaId != 0).ToList());
            return RedirectToAction("Index", "TailoringItems");
        }

    }
}