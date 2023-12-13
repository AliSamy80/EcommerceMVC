using Microsoft.EntityFrameworkCore;

namespace ECommerceAp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ItemImage> ItemsImages { get; set; }
        public DbSet<SalesInvoice> SalesInvoices { get; set; }
        public DbSet<SalesItemBridge> salesItemBridges { get; set; }
        public DbSet<Slider>  Sliders { get; set; }

    }
}
