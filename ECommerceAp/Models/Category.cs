using System.ComponentModel.DataAnnotations;

namespace ECommerceAp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Item> items { get; set; }
    }
}
