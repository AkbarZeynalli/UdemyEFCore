using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UdemyEFCore.DatabaseFirst.DAL
{
    public static class DbContextInitializer
    {
        public static IConfigurationRoot Configuration { get; private set; }
        public static DbContextOptions<AppDBContext> Options { get; private set; }

        public static void Build()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            Options = new DbContextOptionsBuilder<AppDBContext>()
                .UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                .Options;
        }
    }
}
