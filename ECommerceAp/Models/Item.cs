namespace ECommerceAp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalesPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ItemImage> ItemImages { get; set; }
    }
}
