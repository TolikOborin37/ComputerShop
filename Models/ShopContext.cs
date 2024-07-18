using Microsoft.EntityFrameworkCore;

namespace ComputerShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supply> Supply { get; set; }
    }
}
