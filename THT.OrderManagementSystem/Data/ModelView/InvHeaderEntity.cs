namespace THT.OrderManagementSystem.Data.ModelView
{
    public class InvHeaderEntity : InvHeader
    {
        public string VisitorName { get; set; }
        public string CustomerName { get; set; }
        public string SaveTimeFa { get; set; }
        public string Address { get; set; }
        public double? InvPrice { get; set; }  
    }
}
