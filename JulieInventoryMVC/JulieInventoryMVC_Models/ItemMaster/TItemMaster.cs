﻿using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JulieInventoryMVC_Models.ItemMaster
{
    public class TItemMaster
    {
        public int? TItemId { get; set; }
        public string TItemCode { get; set; } = string.Empty;
        public string BarCode { get; set; } = string.Empty;
        public string TItemName { get; set; } = string.Empty;
        public double TItemRate { get; set; } = 0.0;
        public double CuttingRate { get; set; } = 0.0;
        public double SewingRate { get; set; } = 0.0;
        public double MaterialRate { get; set; } = 0.0;
        public string ItemType { get; set; } = string.Empty;
        public string ItemCategory { get; set; } = string.Empty;
        public string MfgName { get; set; } = string.Empty;
        public string ItemSize { get; set; } = string.Empty;
        public string ItemSizeRange { get; set; } = string.Empty;
        public string ItemColor { get; set; } = string.Empty;
        public string ItemFor { get; set; } = string.Empty;
        public string UOM { get; set; } = string.Empty;
        public string AUOM { get; set; } = string.Empty;
        public double UOMValue { get; set; } = 0.0;
        public double AUOMValue { get; set; } = 0.0;
        public double PurchaseRate { get; set; } = 0.0;
        public double MRP { get; set; } = 0.0;
        public double SalesRate { get; set; } = 0.0;
        public double SalesRateA { get; set; } = 0.0;
        public string SalesUOM { get; set; } = string.Empty;
        public string ImgPath { get; set; } = string.Empty;
        public byte[] ItemImage { get; set; }
        public int? ReOrderLevel { get; set; }
        public string ItemSubType { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string HSNCode { get; set; } = string.Empty;
        public double TaxPer { get; set; } = 0.0;
        public int? CId { get; set; }
        public string Sys_Name { get; set; } = string.Empty;
        public DateTime? Sys_Time { get; set; }
        public string CurrUsr { get; set; } = string.Empty;
        public string TItemName1 { get; set; } = string.Empty;
        public string M1 { get; set; } = string.Empty;
        public string M2 { get; set; } = string.Empty;
        public string M3 { get; set; } = string.Empty;
        public string M4 { get; set; } = string.Empty;
        public string M5 { get; set; } = string.Empty;
        public string M6 { get; set; } = string.Empty;
        public string M7 { get; set; } = string.Empty;
        public string M8 { get; set; } = string.Empty;
        public string M9 { get; set; } = string.Empty;
        public string M10 { get; set; } = string.Empty;
        public string M11 { get; set; } = string.Empty;
        public string M12 { get; set; } = string.Empty;
        public string M13 { get; set; } = string.Empty;
        public string M14 { get; set; } = string.Empty;
        public string M15 { get; set; } = string.Empty;
        public string M16 { get; set; } = string.Empty;
        public string M17 { get; set; } = string.Empty;
        public string M18 { get; set; } = string.Empty;
        public string M19 { get; set; } = string.Empty;
        public string M20 { get; set; } = string.Empty;
        public string M21 { get; set; } = string.Empty;
        public string M22 { get; set; } = string.Empty;
        public string M23 { get; set; } = string.Empty;
        public string M24 { get; set; } = string.Empty;
        public string M25 { get; set; } = string.Empty;
        public string M26 { get; set; } = string.Empty;
        public string M27 { get; set; } = string.Empty;
        public string M28 { get; set; } = string.Empty;
        public string M29 { get; set; } = string.Empty;
        public string M30 { get; set; } = string.Empty;
        public string M31 { get; set; } = string.Empty;
        public string M32 { get; set; } = string.Empty;
        public string M33 { get; set; } = string.Empty;
        public string M34 { get; set; } = string.Empty;
        public string M35 { get; set; } = string.Empty;
        public string M36 { get; set; } = string.Empty;
        public string M37 { get; set; } = string.Empty;
        public string M38 { get; set; } = string.Empty;
        public string M39 { get; set; } = string.Empty;
        public string M40 { get; set; } = string.Empty;
        public string M41 { get; set; } = string.Empty;
        public string M42 { get; set; } = string.Empty;
        public string M43 { get; set; } = string.Empty;
        public string M44 { get; set; } = string.Empty;
        public string M45 { get; set; } = string.Empty;
        public string M46 { get; set; } = string.Empty;
        public string M47 { get; set; } = string.Empty;
        public string M48 { get; set; } = string.Empty;
        public string M49 { get; set; } = string.Empty;
        public bool ManageStock { get; set; }
        public string DesignNo { get; set; } = string.Empty;
        public string CatalogName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int? ItemGroupId { get; set; }
        public double OnePieceStitchingHrs { get; set; } = 0.0;
        public double AlterRate { get; set; } = 0.0;
        public double SewingRate_R { get; set; } = 0.0;
        public double SewingRate_Jw { get; set; } = 0.0;
        public double SewingRate_Jw_R { get; set; } = 0.0;
        public double AlterCharge { get; set; } = 0.0;
        public double AlterCharge_R { get; set; } = 0.0;
        public double CommissionPer { get; set; } = 0.0;
        public double CommissionAmt { get; set; } = 0.0;
        public string BarcodeType { get; set; } = string.Empty;
        public int? MainItemId { get; set; }
        public string ItemSubCategory { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
        public double PurchaseDiscPer { get; set; } = 0.0;
        public double SalesDiscPer { get; set; } = 0.0;
        public string ItemGroupName { get; set; } = string.Empty;
        public int? ProductionLimit { get; set; }
        public FormFile Attach { get; set; }


        //public TItemMaster()
        //{
        //    this.TItemId = TItemId;
        //    this.TItemCode = TItemCode;
        //    this.BarCode = BarCode;
        //    this.TItemName = TItemName;
        //    this.TItemRate = TItemRate;
        //    this.CuttingRate = CuttingRate;
        //    this.SewingRate = SewingRate;
        //    this.MaterialRate = MaterialRate;
        //    this.ItemType = ItemType;
        //    this.ItemCategory = ItemCategory;
        //    this.MfgName = MfgName;
        //    this.ItemSize = ItemSize;
        //    this.ItemSizeRange = ItemSizeRange;
        //    this.ItemColor = ItemColor;
        //    this.ItemFor = ItemFor;
        //    this.UOM = UOM;
        //    this.AUOM = AUOM;
        //    this.UOMValue = UOMValue;
        //    this.AUOMValue = AUOMValue;
        //    this.PurchaseRate = PurchaseRate;
        //    this.MRP = MRP;
        //    this.SalesRate = SalesRate;
        //    this.SalesRateA = SalesRateA;
        //    this.SalesUOM = SalesUOM;
        //    this.ImgPath = ImgPath;
        //    this.ItemImage = ItemImage;
        //    this.ReOrderLevel = ReOrderLevel;
        //    this.ItemSubType = ItemSubType;
        //    this.IsActive = IsActive;
        //    this.HSNCode = HSNCode;
        //    this.TaxPer = TaxPer;
        //    this.CId = CId;
        //    this.Sys_Name = Sys_Name;
        //    this.Sys_Time = Sys_Time;
        //    this.CurrUsr = CurrUsr;
        //    this.TItemName1 = TItemName1;
        //    this.M1 = M1;
        //    this.M2 = M2;
        //    this.M3 = M3;
        //    this.M4 = M4;
        //    this.M5 = M5;
        //    this.M6 = M6;
        //    this.M7 = M7;
        //    this.M8 = M8;
        //    this.M9 = M9;
        //    this.M10 = M10;
        //    this.M11 = M11;
        //    this.M12 = M12;
        //    this.M13 = M13;
        //    this.M14 = M14;
        //    this.M15 = M15;
        //    this.M16 = M16;
        //    this.M17 = M17;
        //    this.M18 = M18;
        //    this.M19 = M19;
        //    this.M20 = M20;
        //    this.M21 = M21;
        //    this.M22 = M22;
        //    this.M23 = M23;
        //    this.M24 = M24;
        //    this.M25 = M25;
        //    this.M26 = M26;
        //    this.M27 = M27;
        //    this.M28 = M28;
        //    this.M29 = M29;
        //    this.M30 = M30;
        //    this.M31 = M31;
        //    this.M32 = M32;
        //    this.M33 = M33;
        //    this.M34 = M34;
        //    this.M35 = M35;
        //    this.M36 = M36;
        //    this.M37 = M37;
        //    this.M38 = M38;
        //    this.M39 = M39;
        //    this.M40 = M40;
        //    this.M41 = M41;
        //    this.M42 = M42;
        //    this.M43 = M43;
        //    this.M44 = M44;
        //    this.M45 = M45;
        //    this.M46 = M46;
        //    this.M47 = M47;
        //    this.M48 = M48;
        //    this.M49 = M49;
        //    this.ManageStock = ManageStock;
        //    this.DesignNo = DesignNo;
        //    this.CatalogName = CatalogName;
        //    this.Location = Location;
        //    this.ItemGroupId = ItemGroupId;
        //    this.OnePieceStitchingHrs = OnePieceStitchingHrs;
        //    this.AlterRate = AlterRate;
        //    this.SewingRate_R = SewingRate_R;
        //    this.SewingRate_Jw = SewingRate_Jw;
        //    this.SewingRate_Jw_R = SewingRate_Jw_R;
        //    this.AlterCharge = AlterCharge;
        //    this.AlterCharge_R = AlterCharge_R;
        //    this.CommissionPer = CommissionPer;
        //    this.CommissionAmt = CommissionAmt;
        //    this.BarcodeType = BarcodeType;
        //    this.MainItemId = MainItemId;
        //    this.ItemSubCategory = ItemSubCategory;
        //    this.SupplierName = SupplierName;
        //    this.PurchaseDiscPer = PurchaseDiscPer;
        //    this.SalesDiscPer = SalesDiscPer;
        //    this.ItemGroupName = ItemGroupName;
        //    this.ProductionLimit = ProductionLimit;
        //}
    }
}
