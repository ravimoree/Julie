using Dapper;
using JulieInventoryMVC_Helpers;
using JulieInventoryMVC_Models.ItemMaster;
using JulieInventoryMVC_Models.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Services.TItemMaster
{
    public class TItemMasterServices : ITItemMasterServices
    {
        public int AddItemMaster(JulieInventoryMVC_Models.ItemMaster.TItemMaster modal)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@TItemCode", modal.TItemCode);
            param.Add("@BarCode", modal.BarCode);
            param.Add("@TItemName", modal.TItemName);
            param.Add("@TItemRate", modal.TItemRate);
            param.Add("@CuttingRate", modal.CuttingRate);
            param.Add("@SewingRate", modal.SewingRate);
            param.Add("@MaterialRate", modal.MaterialRate);
            param.Add("@ItemType", modal.ItemType);
            param.Add("@ItemCategory", modal.ItemCategory);
            param.Add("@MfgName", modal.MfgName);
            param.Add("@ItemSize", modal.ItemSize);
            param.Add("@ItemSizeRange", modal.ItemSizeRange);
            param.Add("@ItemColor", modal.ItemColor);
            param.Add("@ItemFor", modal.ItemFor);


            if (modal.UOM != null)
            {
                param.Add("@UOM", modal.UOM);
                param.Add("@AUOM", modal.AUOM);
            }
            else
            {
                param.Add("@UOM", modal.UOM);
                param.Add("@AUOM", modal.AUOM);
            }



            param.Add("@UOMValue", modal.UOMValue);
            param.Add("@AUOMValue", modal.AUOMValue);
            param.Add("@PurchaseRate", modal.PurchaseRate);
            param.Add("@MRP", modal.MRP);
            param.Add("@SalesRate", modal.SalesRate);
            param.Add("@SalesRateA", modal.SalesRateA);

            if (modal.UOM != null)
            {
                param.Add("@SalesUOM", modal.SalesUOM);
            }
            else
            {
                param.Add("@SalesUOM", string.Empty);
            }

            param.Add("@ImgPath", modal.ImgPath);

            //if (modal.UOM != null)
            //{
            //    param.Add("@ItemImage",string.Empty );
            //}
            //else
            //{
            //    param.Add("@ItemImage",string.Empty );
            //}
            param.Add("@ReOrderLevel", 0);
            param.Add("@ItemSubType", string.Empty);
            param.Add("@IsActive", modal.IsActive);
            param.Add("@HSNCode", modal.HSNCode);
            param.Add("@TaxPer", modal.TaxPer);
            param.Add("@CId", modal.CId);
            param.Add("@Sys_Name", modal.Sys_Name);
            param.Add("@Sys_Time", modal.Sys_Time);
            param.Add("@CurrUsr", modal.CurrUsr);
            param.Add("@TItemName1", modal.TItemName1);
            param.Add("@ManageStock", modal.ManageStock);
            param.Add("@DesignNo", string.Empty);
            param.Add("@CatalogName", string.Empty);
            param.Add("@Location", string.Empty);
            param.Add("@ItemGroupId", modal.ItemGroupId);
            param.Add("@OnePieceStitchingHrs", modal.OnePieceStitchingHrs);
            param.Add("@AlterRate", modal.AlterRate);
            param.Add("@SewingRate_R", modal.SewingRate_R);
            param.Add("@SewingRate_Jw", modal.SewingRate_Jw);
            param.Add("@SewingRate_Jw_R", modal.SewingRate_Jw_R);
            param.Add("@AlterCharge", modal.AlterCharge);
            param.Add("@AlterCharge_R", modal.AlterCharge_R);
            param.Add("@CommissionPer", string.Empty);
            param.Add("@CommissionAmt", string.Empty);
            param.Add("@M1", string.Empty);
            param.Add("@M2", string.Empty);
            param.Add("@M48", string.Empty);
            param.Add("@M49", string.Empty);
            param.Add("@BarcodeType", string.Empty);
            param.Add("@MainItemId", string.Empty);
            param.Add("@ItemSubCategory", string.Empty);
            param.Add("@SupplierName", string.Empty);
            param.Add("@PurchaseDiscPer", string.Empty);
            param.Add("@SalesDiscPer", string.Empty);
            int data = SqlHelper.ExcutethoutReturn("SP_InsertTItemMaster_Sales_140922", param);
            return data;
        }
        public int UpdateItemMaster(JulieInventoryMVC_Models.ItemMaster.TItemMaster modal)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@TItemCode", modal.TItemCode);
            param.Add("@BarCode", modal.BarCode);
            param.Add("@TItemName", modal.TItemName);
            param.Add("@TItemRate", modal.TItemRate);
            param.Add("@CuttingRate", modal.CuttingRate);
            param.Add("@SewingRate", modal.SewingRate);
            param.Add("@MaterialRate", modal.MaterialRate);
            param.Add("@ItemType", modal.ItemType);
            param.Add("@ItemCategory", modal.ItemCategory);
            param.Add("@MfgName", modal.MfgName);
            param.Add("@ItemSize", modal.ItemSize);
            param.Add("@ItemSizeRange", modal.ItemSizeRange);
            param.Add("@ItemColor", modal.ItemColor);
            param.Add("@ItemFor", modal.ItemFor);

            if (modal.UOM != null)
            {
                param.Add("@UOM", modal.UOM);
                param.Add("@AUOM", modal.AUOM);
            }
            else
            {
                param.Add("@UOM", modal.UOM);
                param.Add("@AUOM", modal.AUOM);
            }
            param.Add("@UOMValue", modal.UOMValue);
            param.Add("@AUOMValue", modal.AUOMValue);
            param.Add("@PurchaseRate", modal.PurchaseRate);
            param.Add("@MRP", modal.MRP);
            param.Add("@SalesRate", modal.SalesRate);
            param.Add("@SalesRateA", modal.SalesRateA);

            if (modal.UOM != null)
            {
                param.Add("@SalesUOM", modal.SalesUOM);
            }
            else
            {
                param.Add("@SalesUOM", string.Empty);
            }

            param.Add("@ImgPath", modal.ImgPath);

            //if (modal.UOM != null)
            //{
            //    param.Add("@ItemImage",string.Empty );
            //}
            //else
            //{
            //    param.Add("@ItemImage",string.Empty );
            //}
            param.Add("@ReOrderLevel", 0);
            param.Add("@ItemSubType", string.Empty);
            param.Add("@IsActive", modal.IsActive);
            param.Add("@HSNCode", modal.HSNCode);
            param.Add("@TaxPer", modal.TaxPer);
            param.Add("@CId", modal.CId);
            param.Add("@Sys_Name", modal.Sys_Name);
            param.Add("@Sys_Time", modal.Sys_Time);
            param.Add("@CurrUsr", modal.CurrUsr);
            param.Add("@TItemName1", modal.TItemName1);
            param.Add("@ManageStock", modal.ManageStock);
            param.Add("@DesignNo", string.Empty);
            param.Add("@CatalogName", string.Empty);
            param.Add("@Location", string.Empty);
            param.Add("@ItemGroupId", modal.ItemGroupId);
            param.Add("@OnePieceStitchingHrs", modal.OnePieceStitchingHrs);
            param.Add("@AlterRate", modal.AlterRate);
            param.Add("@SewingRate_R", modal.SewingRate_R);
            param.Add("@SewingRate_Jw", modal.SewingRate_Jw);
            param.Add("@SewingRate_Jw_R", modal.SewingRate_Jw_R);
            param.Add("@AlterCharge", modal.AlterCharge);
            param.Add("@AlterCharge_R", modal.AlterCharge_R);
            param.Add("@CommissionPer", string.Empty);
            param.Add("@CommissionAmt", string.Empty);
            param.Add("@TItemId", modal.TItemId);
            int data = SqlHelper.ExcutethoutReturn("SP_UpdateTItemMaster_Sales_251021", param);
            return data;
        }
        public int UpdateItemNotesStyles(List<ItemNotesStyles> modal)
        {
            int result = 0;
            int inert = modal.Count();
            foreach (ItemNotesStyles itemNoteStyle in modal)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ParaId", itemNoteStyle.ParaId);
                param.Add("@ParaName", itemNoteStyle.ParaName);
                param.Add("@TItemId", itemNoteStyle.TItemId);
                param.Add("@PrintRequired", itemNoteStyle.PrintRequired);
                param.Add("@PrintOrder", itemNoteStyle.PrintOrder);
                param.Add("@Charge", itemNoteStyle.Charge);
                param.Add("@ChargeW", itemNoteStyle.ChargeW);
                param.Add("@ChargeJW", itemNoteStyle.ChargeJW);
                int data = SqlHelper.ExcutethoutReturn("Sp_UpdateTblTItemNotesStyles", param);
                inert = inert - 1;
            }
            return result;
        }
        public int AddItemNotesStyles(List<ItemNotesStyles> modal, int itemMasterId)
        {
            int result = 0;
            int inert = modal.Count();
            foreach (ItemNotesStyles itemNoteStyle in modal)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ParaName", itemNoteStyle.ParaName);
                param.Add("@TItemId", itemMasterId);
                param.Add("@PrintRequired", itemNoteStyle.PrintRequired);
                param.Add("@PrintOrder", itemNoteStyle.PrintOrder);
                param.Add("@Charge", itemNoteStyle.Charge);
                param.Add("@ChargeW", itemNoteStyle.ChargeW);
                param.Add("@ChargeJW", itemNoteStyle.ChargeJW);
                int data = SqlHelper.ExcutethoutReturn("Sp_InsertTblTItemNotesStyles", param);
                inert = inert - 1;
            }
            return result;
        }
        public int AddItemParameter(List<ItemParameter> modal, int itemMasterId)
        {
            int result = 0;
            int inert = modal.Count();
            foreach (ItemParameter itemNoteStyle in modal)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ParaName", itemNoteStyle.ParaName);
                param.Add("@TItemId", itemMasterId);
                param.Add("@PrintRequired", itemNoteStyle.PrintRequired);
                param.Add("@PrintOrder", itemNoteStyle.PrintOrder);
                int data = SqlHelper.ExcutethoutReturn("Sp_InsertTblTItemParameter", param);
                inert = inert - 1;
            }
            return result;
        }
        public int UpdateItemParameter(List<ItemParameter> modal)
        {
            int result = 0;
            int inert = modal.Count();
            foreach (ItemParameter itemNoteStyle in modal)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ParaId", itemNoteStyle.ParaId);
                param.Add("@ParaName", itemNoteStyle.ParaName);
                param.Add("@TItemId", itemNoteStyle.TItemId);
                param.Add("@PrintRequired", itemNoteStyle.PrintRequired);
                param.Add("@PrintOrder", itemNoteStyle.PrintOrder);
                int data = SqlHelper.ExcutethoutReturn("SP_UpdateTItemParameter", param);
                inert = inert - 1;
            }
            return result;
        }
        public List<JulieInventoryMVC_Models.ItemMaster.TItemMaster> GetTItemMaster()
        {
            var ulist = SqlHelper.GetRecordList<JulieInventoryMVC_Models.ItemMaster.TItemMaster>("Sp_GetTItemMasterList").ToList();
            return ulist;
        }
        public int DeleteItemMaster(int id)
        {
            int result = 0;
            DynamicParameters param = new DynamicParameters();
            param.Add("@TItemId", id);
            int data = SqlHelper.ExcutethoutReturn("Sp_DeleteItemMaster", param);
            return data != 0 ? 1 : 0;
        }
        public ItemMasterVM GetItemMaster(int id)
        {
            ItemMasterVM itemMasterVM =new ItemMasterVM();
            List<ParameterInfo> param = new List<ParameterInfo>();
            param.Add(new ParameterInfo() { ParameterName = "@TItemId", ParameterValue = id });
            DynamicParameters param1 = new DynamicParameters();
            param1.Add("@TItemId", id);
            var datas= SqlHelper.ReturnList<JulieInventoryMVC_Models.ItemMaster.TItemMaster>("Sp_GetIteamMasterById", param1).FirstOrDefault<JulieInventoryMVC_Models.ItemMaster.TItemMaster>(); ;
            var ParametersList = SqlHelper.GetRecords<ItemParameter>("Sp_GetIteamMasterParameter", param).OrderBy(x => x.PrintOrder).ToList();
            var NotesStylesList = SqlHelper.GetRecords<ItemNotesStyles>("Sp_GetItemNotesStyles", param).OrderBy(x => x.PrintOrder).ToList();
            itemMasterVM.itemMasterJson =  datas;
            itemMasterVM.Parameters = ParametersList;
            itemMasterVM.NotesStyles = NotesStylesList;

            return itemMasterVM;
        }

    }
}
