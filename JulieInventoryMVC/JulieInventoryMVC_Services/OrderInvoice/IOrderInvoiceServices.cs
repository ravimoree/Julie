using JulieInventoryMVC_Models.OrderInvoiceMaster;
using System.Collections.Generic;

namespace JulieInventoryMVC_Services.OrderInvoice
{
    public interface IOrderInvoiceServices
    {
        List<OrderInvoiceMaster> GetInvoiceMasters(int cid, bool isActive = false);

        List<MesurementVM> GetMesurements(int cid);
        List<MesurementVM> GetSalesMan(int cid);
        List<ItemNameVM> GetItemName(int cid, int leadId);
        List<IteamNameParamiter> GetItemNameParamiter(int leadId);
        int GetinvoiceNO(int cid);


    }
}
