using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StripPayment.Server.Data;
using StripPayment.Shared.Models;

namespace StripPayment.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpPost]
    public async Task<IActionResult> Create(Product productToCreate)
    {
        productToCreate.Id = Guid.NewGuid().ToString();

        await _context.AddAsync(productToCreate);

        await _context.SaveChangesAsync();

        return Ok(productToCreate);
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> Get()
    {
        return await _context.Products.ToListAsync();
    }

    [HttpPut]
    public async Task<IActionResult> Update(Product updatedProduct)
    {
        _context.Update(updatedProduct);

        await _context.SaveChangesAsync();

        return Ok(updatedProduct);
    }

    [HttpDelete]
    [Route("{productToDeleteId}")]
    public async Task<IActionResult> Update(string productToDeleteId)
    {
        var productToDelete = await _context.Products.FindAsync(productToDeleteId);

        if (productToDelete == null)
            return NotFound();

        _context.Remove(productToDelete);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
