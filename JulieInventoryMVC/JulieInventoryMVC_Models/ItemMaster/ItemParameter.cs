using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Models.ItemMaster
{
    public class ItemParameter
    {
        public int ParaId { get; set; }
        public string ParaName { get; set; }
        public int TItemId { get; set; }
        public bool PrintRequired { get; set; }=true;
        public int PrintOrder { get; set; }
        public ItemParameter()
        {
            this.ParaId = ParaId;
            this.ParaName = ParaName;
            this.TItemId = TItemId;
            this.PrintRequired = PrintRequired;
            this.PrintOrder = PrintOrder;
        }
    }
}
