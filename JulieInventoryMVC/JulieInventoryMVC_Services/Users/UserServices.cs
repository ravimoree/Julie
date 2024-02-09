using JulieInventoryMVC_Helpers;
using JulieInventoryMVC_Models.Users;
using System.Collections.Generic;

namespace JulieInventoryMVC_Services.Users
{
    public class UserServices : IUserServices
    {
        public int AddUser(UserMaster modal)
        {
            List<ParameterInfo> param = new List<ParameterInfo>();
            param.Add(new ParameterInfo() { ParameterName = "@UserId", ParameterValue = modal.UserId });
            param.Add(new ParameterInfo() { ParameterName = "@UserName", ParameterValue = modal.UserName });
            param.Add(new ParameterInfo() { ParameterName = "@UserPwd", ParameterValue = modal.UserPwd });
            param.Add(new ParameterInfo() { ParameterName = "@DeptId", ParameterValue = modal.DeptId });
            param.Add(new ParameterInfo() { ParameterName = "@PrintName", ParameterValue = modal.PrintName });
            param.Add(new ParameterInfo() { ParameterName = "@CId", ParameterValue = modal.CId });
            param.Add(new ParameterInfo() { ParameterName = "@Sys_Name", ParameterValue = modal.Sys_Name });
            param.Add(new ParameterInfo() { ParameterName = "@Sys_Time", ParameterValue = modal.Sys_Time });
            param.Add(new ParameterInfo() { ParameterName = "@CurrUsr", ParameterValue = modal.CurrUsr });
            param.Add(new ParameterInfo() { ParameterName = "@LedgerId", ParameterValue = modal.LedgerId });
            param.Add(new ParameterInfo() { ParameterName = "@Barcode_CIdList", ParameterValue = modal.Barcode_CIdList });
            param.Add(new ParameterInfo() { ParameterName = "@MobileNo", ParameterValue = modal.MobileNo });
            param.Add(new ParameterInfo() { ParameterName = "@IsOTPRequired", ParameterValue = modal.IsOTPRequired });
            param.Add(new ParameterInfo() { ParameterName = "@EmailId", ParameterValue = modal.EmailId });
            param.Add(new ParameterInfo() { ParameterName = "@IsDemo", ParameterValue = modal.IsDemo });
            param.Add(new ParameterInfo() { ParameterName = "@IsAdmin", ParameterValue = modal.IsAdmin });
            int data = SqlHelper.GetIntRecord<UserModels>("Sp_InsertUpdatetbluser", param);
            return data != 0 ? 1 : 0;
        }

        public UserMaster GetUser(string email)
        {
            List<ParameterInfo> param = new List<ParameterInfo>();
            param.Add(new ParameterInfo() { ParameterName = "@UserName", ParameterValue = email });
            var ulist = SqlHelper.GetRecord<UserMaster>("Sp_GetUsers", param);
            return ulist;
        }
    }
}
