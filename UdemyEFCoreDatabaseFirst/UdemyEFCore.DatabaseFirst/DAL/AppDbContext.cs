using Microsoft.EntityFrameworkCore;

namespace UdemyEFCore.DatabaseFirst.DAL
{
    public class AppDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }
    }
}
