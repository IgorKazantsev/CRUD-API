using Microsoft.AspNetCore.Mvc; // Provides classes and attributes for building web APIs.
using MyWebAPI.Data; // This imports the namespace where ApplicationDbContext is defined, allowing database access.

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ProductsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/products
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_context.Products.ToList());
    }

    // POST: api/products
    [HttpPost]
    public IActionResult AddProduct([FromBody] Product product)
    {
        if (product == null)
        {
            return BadRequest("Product cannot be null");
        }

        _context.Products.Add(product);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, product);
    }
}