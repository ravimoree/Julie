using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using JulieInventoryMVC.Models;
using JulieInventoryMVC_Models.ItemMaster;
using JulieInventoryMVC_Services.TItemMaster;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PagedList;

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
        public ActionResult Creates(string ItemMasterData,string ParametersData, string NotesStylesData)
        {
            var itemMaster = new ItemMasterVM()
            {
                ItemMaster = new TItemMaster(),
                Parameters=new List<ItemParameter>(),
                NotesStyles = new List<ItemNotesStyles>()
            };
            HttpFileCollectionBase file1 = Request.Files;

            itemMaster.ItemMaster = JsonConvert.DeserializeObject<TItemMaster>(ItemMasterData);
            itemMaster.Parameters= JsonConvert.DeserializeObject<List<ItemParameter>>(ParametersData);
            itemMaster.NotesStyles = JsonConvert.DeserializeObject<List<ItemNotesStyles>>(NotesStylesData);


            if (!string.IsNullOrEmpty(ItemMasterData))
            {
            }
            if (Request.Files.Count > 0)
            {
                HttpFileCollectionBase files = Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";
                    string filename = Path.GetFileName(Request.Files[i].FileName);

                    HttpPostedFileBase file = files[i];
                    string fname;
                    if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                    {
                        string[] testfiles = file.FileName.Split(new char[] { '\\' });
                        fname = testfiles[testfiles.Length - 1];
                    }
                    else
                    {
                        fname = file.FileName;
                    }

                    fname = Path.Combine(Server.MapPath("~/Image/ItemMaster/"), fname);
                    //Please uncommet below line before comite or test
                    //   file.SaveAs(fname);
                }
            }


            //data.itemMasterJson.ImgPath= path;  
            itemMaster.ItemMaster.Sys_Time = DateTime.Now;
            itemMaster.ItemMaster.CurrUsr = Request["UserName"];
            var insert = _dc.AddItemMaster(itemMaster.ItemMaster);
            var para = _dc.AddItemParameter(itemMaster.Parameters, insert);
            var notes = _dc.AddItemNotesStyles(itemMaster.NotesStyles, insert);

            return RedirectToAction("Index", "TailoringItems");

        }

        public ActionResult UploadFiles()
        {
            if (Request.Files.Count > 0)
            {
                HttpFileCollectionBase files = Request.Files;
                var id = Request["ItemMaster"];

                for (int i = 0; i < files.Count; i++)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";
                    string filename = Path.GetFileName(Request.Files[i].FileName);

                    HttpPostedFileBase file = files[i];
                    string fname;
                    if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                    {
                        string[] testfiles = file.FileName.Split(new char[] { '\\' });
                        fname = testfiles[testfiles.Length - 1];
                    }
                    else
                    {
                        fname = file.FileName;
                    }

                    fname = Path.Combine(Server.MapPath("~/Image/ItemMaster/"), fname);
                    file.SaveAs(fname);
                }
            }
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