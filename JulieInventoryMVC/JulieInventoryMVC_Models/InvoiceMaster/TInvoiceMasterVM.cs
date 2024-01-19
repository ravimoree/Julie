using System.Collections.Generic;

namespace JulieInventoryMVC_Models.ItemMaster
{
    public class TInvoiceMasterVM
    {
        public InvoiceMaster.InvoiceMaster invoiceMaster { get; set; }
        public List<InvoiceMaster.InvoiceDetail> invoiceDetails { get; set; }
        public List<InvoiceMaster.InvoiceStyleDetail> invoiceStyleDetails  { get; set; }
        public List<InvoiceMaster.InvoiceSubDetail> invoiceSubDetails { get; set; }
    }
}
