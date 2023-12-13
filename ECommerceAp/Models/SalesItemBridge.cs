namespace ECommerceAp.Models
{
    public class SalesItemBridge
    {
        public int Id { get; set; }
        public double SalesPrice { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int InvoiceId { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
    }
}
