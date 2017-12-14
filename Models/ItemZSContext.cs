using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class ItemZsContext : DbContext
    {
        public ItemZsContext(DbContextOptions<ItemZsContext> options)
                : base(options)
        {
        }

        public DbSet<ItemZsContext>ItemZsList { get; set; }
    }
}