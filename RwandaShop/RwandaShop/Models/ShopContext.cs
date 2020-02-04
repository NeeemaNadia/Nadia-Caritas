using Microsoft.EntityFrameworkCore;

namespace RwandaShop.Models
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }
        public DbSet<Shop> Shops { get; set; }
    }
}