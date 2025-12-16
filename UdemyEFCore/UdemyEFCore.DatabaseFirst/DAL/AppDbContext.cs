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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H6VMCSI\\SQLEXPRESS;Initial Catalog=UdemyEFCoreDatabaseFirstDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
