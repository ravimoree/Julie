using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Models.OrderInvoiceMaster
{
    public class ItemNameVM
    {
        public int TItemId { get; set; }
        public string TItemName { get; set; }
        public string TItemCode { get; set; }
        public float TItemRate { get; set; }
        public string ItemSubType { get; set; }
        public string HSNCode { get; set; }
        public float TaxPer { get; set; }
        public string ItemSize { get; set; }
        public int ItemGroupId { get; set; }
        public string ItemGroupName { get; set; }
        public string ItemGroupNameR { get; set; }
        public int ProductionLimit { get; set; }
    }
}
