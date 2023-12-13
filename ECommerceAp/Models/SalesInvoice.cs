namespace ECommerceAp.Models
{
    public class SalesInvoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime DeliveryDate { get; set; }
        public string Notes { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
