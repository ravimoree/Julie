using JulieInventoryMVC_Models.OrderInvoiceMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieInventoryMVC_Services.OrderInvoice
{
    public interface IOrderInvoiceServices
    {
        List<OrderInvoiceMaster> GetInvoiceMasters(int cid,bool isActive=false);

        List<MesurementVM> GetMesurements(int cid);
        List<MesurementVM> GetSalesMan(int cid);
        List<ItemNameVM> GetItemName(int cid, int leadId);
        int GetinvoiceNO();


    }
}
