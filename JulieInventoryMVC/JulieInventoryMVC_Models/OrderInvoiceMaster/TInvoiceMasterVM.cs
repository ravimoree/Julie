using JulieInventoryMVC_Models.InvoiceMaster;
using System.Collections.Generic;

namespace JulieInventoryMVC_Models.OrderInvoice
{
    public class TInvoiceMasterVM
    {
       // public OrderInvoiceMaster invoiceMaster { get; set; }
        public List<InvoiceDetail> invoiceDetails { get; set; }
        public List<InvoiceStyleDetail> invoiceStyleDetails  { get; set; }
        public List<InvoiceSubDetail> invoiceSubDetails { get; set; }
    }
}
