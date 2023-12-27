using JulieInventoryMVC.App_Start;
using JulieInventoryMVC.Models;
using JulieInventoryMVC_Services.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using JulieInventoryMVC_Models.Users;

namespace JulieInventoryMVC.Controllers
{
    [SessionExpire(false)]
    public class AccountController : Controller
    {
        IUserServices _users = new UserServices();

        // GET: Account
        public ActionResult Login()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLogin models)
        {
            var data = _users.GetUser(models.Email);
            //var DecryptPass = Decrypt(data.Password);
            if (data!=null)
            {
                if (data.UserPwd == models.Password)
                {
                    HttpCookie myCookie = new HttpCookie("LoginCookie");
                    Response.Cookies.Remove("LoginCookie");
                    Response.Cookies.Add(myCookie);
                    myCookie.Values.Add("UseId", data.UserId.ToString());
                    myCookie.Values.Add("UserName", data.UserName);
                    Session["UserId"] = data.UserId;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["message"] = "Password Not";
                    return RedirectToAction("Login", "Account");
                }
            }
            else
            {
                TempData["message"] = "User Not";
                return RedirectToAction("Login", "Account");
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModels models)
        {
            return View();
        }

        public ActionResult Logout()
        {
            HttpCookie myCookie = new HttpCookie("LoginCookie");
            myCookie.Expires = DateTime.Now.AddDays(-1d);

            Session.Clear(); 
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }

        #region PasswordConvert
        private string Encrypt(string clearText)
        {
            string encryptionKey = "Julie@2023MORV2992(@";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string encryptionKey = "Julie@2023MORV2992(@";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return cipherText;
        }

        #endregion    
    }
}