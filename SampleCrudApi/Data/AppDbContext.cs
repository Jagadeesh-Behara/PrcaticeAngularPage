using Microsoft.EntityFrameworkCore;

namespace SampleCrudApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Product> Products =>Set<Models.Product>();
    }
}
