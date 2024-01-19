using System.Collections.Generic;

namespace JulieInventoryMVC_Models.ItemMaster
{
    public class TItemMasterVM
    {
        public List<TItemMaster> Data { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
    }
}
