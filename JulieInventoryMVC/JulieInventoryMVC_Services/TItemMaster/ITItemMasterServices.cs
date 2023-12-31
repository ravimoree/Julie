using JulieInventoryMVC_Models.ItemMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Services.TItemMaster
{
    public interface ITItemMasterServices
    {
        List<JulieInventoryMVC_Models.ItemMaster.TItemMaster> GetTItemMaster();
        int AddItemMaster(JulieInventoryMVC_Models.ItemMaster.TItemMaster modal);
        int AddItemParameter(List<ItemParameter> modal, int itemMasterId);
        int AddItemNotesStyles(List<ItemNotesStyles> modal, int itemMasterId);
        int UpdateItemParameter(List<ItemParameter> modal);
        int UpdateItemNotesStyles(List<ItemNotesStyles> modal);
        int DeleteItemMaster(int id);
        ItemMasterVM GetItemMaster(int id);
        List<MiscMaster> GetMiscMaster(int id);
        List<ItemGroupMaster> GetItemGroupMaster();


    }
}
