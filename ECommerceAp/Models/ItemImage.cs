namespace ECommerceAp.Models
{
    public class ItemImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
