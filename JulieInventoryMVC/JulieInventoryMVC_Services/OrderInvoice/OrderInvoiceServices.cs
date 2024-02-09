using Dapper;
using JulieInventoryMVC_Helpers;
using JulieInventoryMVC_Models.ItemMaster;
using JulieInventoryMVC_Models.OrderInvoiceMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace JulieInventoryMVC_Services.OrderInvoice
{
    public class OrderInvoiceServices : IOrderInvoiceServices
    {
        public List<OrderInvoiceMaster> GetInvoiceMasters(int cid, bool isActive)
        {
            List<OrderInvoiceMaster> dataList = new List<OrderInvoiceMaster>();
            DynamicParameters param1 = new DynamicParameters();
            param1.Add("@cid", cid);
            dataList = SqlHelper.ReturnList<OrderInvoiceMaster>("Sp_GetInvoiceMaster", param1).ToList();
            return dataList;
        }

        public List<MesurementVM> GetMesurements(int cid)
        {
            List<MesurementVM> miscMasters = new List<MesurementVM>();
            DynamicParameters param1 = new DynamicParameters();
            param1.Add("@cid", cid);
            miscMasters = SqlHelper.ReturnList<MesurementVM>("Sp_GetMasermentList", param1).ToList();
            return miscMasters;
        }
        public List<MesurementVM> GetSalesMan(int cid)
        {
            List<MesurementVM> miscMasters = new List<MesurementVM>();
            DynamicParameters param1 = new DynamicParameters();
            param1.Add("@cid", cid);
            miscMasters = SqlHelper.ReturnList<MesurementVM>("Sp_GetSaleManList", param1).ToList();
            return miscMasters;
        }
        public List<ItemNameVM> GetItemName(int cid, int leadId)
        {
            List<ItemNameVM> miscMasters = new List<ItemNameVM>();
            DynamicParameters param1 = new DynamicParameters();
            param1.Add("@CId", cid);
            param1.Add("@leadId", leadId);
            miscMasters = SqlHelper.ReturnList<ItemNameVM>("Sp_GetIteamName", param1).ToList();
            return miscMasters;
        }
        public List<IteamNameParamiter> GetItemNameParamiter(int leadId)
        {
            List<IteamNameParamiter> miscMasters = new List<IteamNameParamiter>();
            DynamicParameters param1 = new DynamicParameters();
            param1.Add("@id", leadId);
            miscMasters = SqlHelper.ReturnList<IteamNameParamiter>("Sp_GetItemNameParamiter", param1).ToList();
            return miscMasters;
        }
        public int GetinvoiceNO(int cid)
        {
            DynamicParameters param1 = new DynamicParameters();
            param1.Add("@cid", cid);
            var data= SqlHelper.ReturnList<OrderInvoiceMaster>("Sp_GetInvoiceMaster", param1).ToList();
            int invoce = data.Max(x => x.InvoiceNo);
            return invoce;
        }
    }
}
