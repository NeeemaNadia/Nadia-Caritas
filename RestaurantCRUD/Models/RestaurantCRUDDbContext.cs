using Microsoft.EntityFrameworkCore;

namespace RestaurantCRUD.Models
{
    public class RestaurantCRUDDbContext: DbContext
    {
        public RestaurantCRUDDbContext(DbContextOptions<RestaurantCRUDDbContext> options) : base(options)
        {
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}