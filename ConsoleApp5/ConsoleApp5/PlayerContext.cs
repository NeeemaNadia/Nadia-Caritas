using Microsoft.EntityFrameworkCore;

namespace ConsoleApp5
{
    public class PlayerContext:DbContext
    {
     public   DbSet<Players> Players { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
       //  base.OnConfiguring(optionsBuilder);
       optionsBuilder.UseSqlite(@"Data source=Players.Db");
     }
    }
}