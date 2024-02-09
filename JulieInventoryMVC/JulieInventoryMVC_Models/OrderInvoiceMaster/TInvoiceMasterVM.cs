using JulieInventoryMVC_Models.InvoiceMaster;
using JulieInventoryMVC_Models.OrderInvoiceMaster;
using System.Collections.Generic;

namespace JulieInventoryMVC_Models.OrderInvoice
{
    public class TInvoiceMasterVM
    {
        // public OrderInvoiceMaster invoiceMaster { get; set; }
        public List<InvoiceDetail> invoiceDetails { get; set; }
        public List<InvoiceStyleDetail> invoiceStyleDetails { get; set; }
        public List<InvoiceSubDetail> invoiceSubDetails { get; set; }
    }

    public class ItemNameDetailsVM
    {
        public ItemNameVM itemName { get; set; }
        public List<IteamNameParamiter> nameParamiters { get; set; }

    }
}
