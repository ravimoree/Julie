using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Models.ItemMaster
{
    public class ItemMasterVM
    {
        public TItemMaster itemMasterJson { get; set; }
        public List<ItemParameter> Parameters { get; set; }
        public List<ItemNotesStyles> NotesStyles { get; set; }
    }
    public class ItemMasterParameterVM
    {
        public List<ItemParameter> Parameters { get; set; }
        public List<ItemNotesStyles> NotesStyles { get; set; }
    }

}
