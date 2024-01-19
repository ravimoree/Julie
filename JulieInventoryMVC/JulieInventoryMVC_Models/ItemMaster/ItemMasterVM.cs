using System.Collections.Generic;

namespace JulieInventoryMVC_Models.ItemMaster
{
    public class ItemMasterVM
    {
        public TItemMaster ItemMaster { get; set; }
        public List<ItemParameter> Parameters { get; set; }
        public List<ItemNotesStyles> NotesStyles { get; set; }

    }
    public class JsonItemMaster
    {
        public string ItemMasterData { get; set; }
        public string ParametersData { get; set; }
        public string NotesStylesData { get; set; }
    }

}
