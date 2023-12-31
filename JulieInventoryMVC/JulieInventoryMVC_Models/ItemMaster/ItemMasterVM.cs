using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Models.ItemMaster
{
    public class ItemMasterVM
    {
        public TItemMaster ItemMaster{ get; set; }
        public List<ItemParameter> Parameters { get; set; }
        public List<ItemNotesStyles> NotesStyles { get; set; }
        
    }
    public class ItemMasterParameterVM
    {
        public List<ItemParameter> Parameters { get; set; }
        public List<ItemNotesStyles> NotesStyles { get; set; }
    }
    public class ParametersJson 
    {
        public string ParaId { get; set; }
        public string ParaName { get; set; }
        public string TItemId { get; set; }
        public string PrintRequired { get; set; } = "true";
        public string PrintOrder { get; set; }
    }
    public class NotesStylesJson
    {
        public string ParaId { get; set; }
        public string ParaName { get; set; }
        public string TItemId { get; set; }
        public string PrintRequired { get; set; } = "true";
        public string PrintOrder { get; set; }
        public string Charge { get; set; }
        public string ChargeW { get; set; }
        public string ChargeJW { get; set; }
    }

}
