using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace UdemyEFCore.DatabaseFirst.DAL
{
    public class AppDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDBContext()
        {
            
        }
        public AppDBContext( DbContextOptions<AppDBContext> options ) : base(options)
        {
            
        }
    }
}
