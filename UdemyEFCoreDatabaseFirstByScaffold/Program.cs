using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using UdemyEFCoreDatabaseFirstByScaffold.Models;

namespace UdemyEFCoreDatabaseFirstByScaffold
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var context = new UdemyEfcoreDatabaseFirstDbContext();

            var products  = await context.Products.ToListAsync();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} - {product.Name} - {product.Price} - {product.Stock}");
            }
        }
    }
}
