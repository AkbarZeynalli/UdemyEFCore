using Concurrency.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Concurrency.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List()
        {
            return View( _context.Products.ToList());
        }

        public async Task<IActionResult> Update(int Id)
        {
            var product = await _context.Products.FindAsync(Id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }
    }
}
