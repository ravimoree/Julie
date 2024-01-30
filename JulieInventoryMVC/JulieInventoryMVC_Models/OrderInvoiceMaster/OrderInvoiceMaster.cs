using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Models.OrderInvoiceMaster
{
    public class OrderInvoiceMaster
    {
        public int InvId { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int LedgerId { get; set; }
        public string Reference { get; set; }
        public int WorkDays { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime TrialDate { get; set; }
        public float TotalAmt { get; set; }
        public float DiscPer { get; set; }
        public float Discount { get; set; }
        public float BillAmt { get; set; }
        public float ReceivedAmt { get; set; }
        public float DueAmt { get; set; }
        public string Remarks { get; set; }
        public string SalesAcType { get; set; }
        public string InvoiceNumber { get; set; }
        public int TIRINo { get; set; }
        public string TIRINumber { get; set; }
        public float Creditdays { get; set; }
        public DateTime SalesDueDate { get; set; }
        public int TS_Id { get; set; }
        public int V_Id { get; set; }
        public float CST_Per { get; set; }
        public float CST_Amt { get; set; }
        public float CST_AddPer { get; set; }
        public float CST_AddAmt { get; set; }
        public float VAT_Per { get; set; }
        public float VAT_Amt { get; set; }
        public float VAT_AddPer { get; set; }
        public float VAT_AddAmt { get; set; }
        public float FreightAmt { get; set; }
        public float AdjustAmt { get; set; }
        public float SalesBillAmt { get; set; }
        public int CId { get; set; }
        public string Sys_Name { get; set; }
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
        public float SP1Per { get; set; }
        public float SP1Amt { get; set; }
        public float SP1Comm { get; set; }
        public string SP2 { get; set; }
        public float SP2Per { get; set; }
        public float SP2Amt { get; set; }
        public float SP2Comm { get; set; }
        public int TokenNo { get; set; }
        public int IE_Gst { get; set; }
        public string OrderFlag { get; set; }
        public int Measurementby_Id { get; set; }
        public int CNAmt { get; set; }
        public string LedgerCode { get; set; }
        public string LedgerName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string MobileNo2 { get; set; }
        public string GSTNo { get; set; }
        public string PANNo { get; set; }
        public string Taxation { get; set; }
        public string CountryCode { get; set; }
        public string TS_Name { get; set; }
        public string VATCST { get; set; }

    }
}
