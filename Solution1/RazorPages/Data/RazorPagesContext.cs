using Microsoft.EntityFrameworkCore;

namespace RazorPages.Data
{
    public class RazorPagesContext : DbContext
    {
        public RazorPagesContext(DbContextOptions<RazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages.Models.Movie> Movie { get; set; } = default!;
    }
}
