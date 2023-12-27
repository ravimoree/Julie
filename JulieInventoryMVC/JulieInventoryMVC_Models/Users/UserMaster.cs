using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Models.Users
{
    public class UserMaster
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public int DeptId { get; set; }
        public string PrintName { get; set; }
        public int CId { get; set; }
        public string Sys_Name { get; set; }
        public DateTime Sys_Time { get; set; }
        public string CurrUsr { get; set; }
        public int LedgerId { get; set; }
        public string Barcode_CIdList { get; set; }
        public string MobileNo { get; set; }
        public bool IsOTPRequired { get; set; }
        public string EmailId { get; set; }
        public bool IsDemo { get; set; }
        public int IsAdmin { get; set; }

        public UserMaster() 
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserPwd = UserPwd;
            this.DeptId = DeptId;
            this.PrintName = PrintName;
            this.CId = CId;
            this.Sys_Name = Sys_Name;
            this.Sys_Time = Sys_Time;
            this.CurrUsr = CurrUsr;
            this.LedgerId = LedgerId;
            this.Barcode_CIdList = Barcode_CIdList;
            this.MobileNo = MobileNo;
            this.IsOTPRequired = IsOTPRequired;
            this.EmailId = EmailId;
            this.IsDemo = IsDemo;
        }
    }
}
