using UdemyEFCore.CodeFirst.Inializer;

namespace UdemyEFCore.CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initializer.Build();

            using (var context = new Data.AppDbContext())
            {
                var products = context.Products.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                }
            }
        }
    }
}
