using UdemyEFCore.DatabaseFirst.DAL;

namespace UdemyEFCore.DatabaseFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            DbContextInitializer.Build();

            using var context = new AppDBContext(DbContextInitializer.Options);

            foreach (var item in context.Products.ToList())
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Price}  - {item.Stock}");
            }
        }
    }
}
