using System;

namespace JulieInventoryMVC_Models.InvoiceMaster
{
    public class InvoiceMaster
    {
        public int InvId { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int LedgerId { get; set; }
        public string Reference { get; set; }
        public int WorkDays { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime TrialDate { get; set; }
        public double TotalAmt { get; set; }
        public double DiscPer { get; set; }
        public double Discount { get; set; }
        public double BillAmt { get; set; }
        public double ReceivedAmt { get; set; }
        public double DueAmt { get; set; }
        public string Remarks { get; set; }
        public string SalesAcType { get; set; }
        public string InvoiceNumber { get; set; }
        public int TIRINo { get; set; }
        public string TIRINumber { get; set; }
        public double Creditdays { get; set; }
        public DateTime SalesDueDate { get; set; }
        public int TS_Id { get; set; }
        public int V_Id { get; set; }
        public double CST_Per { get; set; }
        public double CST_Amt { get; set; }
        public double CST_AddPer { get; set; }
        public double CST_AddAmt { get; set; }
        public double VAT_Per { get; set; }
        public double VAT_Amt { get; set; }
        public double VAT_AddPer { get; set; }
        public double VAT_AddAmt { get; set; }
        public double FreightAmt { get; set; }
        public double AdjustAmt { get; set; }
        public double SalesBillAmt { get; set; }
        public int CId { get; set; }
        public string Sys_Name { get; set; }
        public DateTime Sys_Time { get; set; }
        public string CurrUsr { get; set; }
        public int AcInvoiceNo { get; set; }
        public DateTime AcInvoiceDate { get; set; }
        public DateTime FeedbackDTM { get; set; }
        public string Rating { get; set; }
        public string Feedback { get; set; }
        public string PmtMode { get; set; }
        public string PmtNarration { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }
        public string SP1 { get; set; }
        public double SP1Per { get; set; }
        public double SP1Amt { get; set; }
        public double SP1Comm { get; set; }
        public string SP2 { get; set; }
        public double SP2Per { get; set; }
        public double SP2Amt { get; set; }
        public double SP2Comm { get; set; }
        public int TokenNo { get; set; }
        public string IE_Gst { get; set; }
        public string OrderFlag { get; set; }
        public int Measurementby_Id { get; set; }
        public DateTime TrialDate2 { get; set; }
        public double CNAmt { get; set; }
    }
}
