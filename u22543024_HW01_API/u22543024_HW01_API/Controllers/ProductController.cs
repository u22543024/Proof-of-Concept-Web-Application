using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using u22543024_HW01_API.Data;
using u22543024_HW01_API.Models;

namespace u22543024_HW01_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

       // Get the list of products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        //Get the product details using the product id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductByID(int id) 
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

         // Edit/Update the product details
        [HttpPut("{id}")]
        public async Task<IActionResult> EditProduct(int id, Product product) 
        {
            if (id != product.ID)
            {
                return BadRequest();
            }

            var existingProduct = await _context.Products.FindAsync(id);

            if (existingProduct == null)
            {
                return NotFound();
            }
            _context.Entry(existingProduct).CurrentValues.SetValues(product);

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Add/Create a new prpduct details
        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductByID), new { id = product.ID }, product);
        }

         // Delete existing product details
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
