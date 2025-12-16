using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst.DAL
{
    public class DbContextinitialzer
    {
        public static IConfigurationRoot Configuration;

        public static DbContextOptionsBuilder<AppDBContext> OptionsBuilder;

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            OptionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

    }
}
