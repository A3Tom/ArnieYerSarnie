using ArnieYerSarnie.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ArnieYerSarnie.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options)
            : base(options)
        { }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
    }
}
