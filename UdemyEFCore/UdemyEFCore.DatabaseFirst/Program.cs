using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
             
            var products = new DAL.AppDBContext().Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id} Name: {product.Name} Price: {product.Price}");
            }
        }
    }
}
