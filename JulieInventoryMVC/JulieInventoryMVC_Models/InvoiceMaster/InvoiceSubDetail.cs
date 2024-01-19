namespace JulieInventoryMVC_Models.InvoiceMaster
{
    public class InvoiceSubDetail
    {
        public int SubDetailId { get; set; }
        public int InvId { get; set; }
        public int InvDetailId { get; set; }
        public int TItemId { get; set; }
        public int ParaId { get; set; }
        public string ParaValue { get; set; }
        public string Notes { get; set; }
        public int ImageId { get; set; }
        public double Charges { get; set; }
        public double WorkerDesignChrg { get; set; }
        public double JwDesignChrg { get; set; }
        public string ParaValue2 { get; set; }
    }
}
