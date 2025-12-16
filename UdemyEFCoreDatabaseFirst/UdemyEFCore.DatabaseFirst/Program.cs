using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyEFCore.DatabaseFirst.DAL;

namespace UdemyEFCore.DatabaseFirst
{

    public class Program
    {
        static void Main(string[] args)
        {
            DbContextinitialzer.Build();

            var products = new AppDBContext(DbContextinitialzer.OptionsBuilder.Options);

            foreach (var item in products.Products.ToList())
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Price}");
            }
        }
    }
}
