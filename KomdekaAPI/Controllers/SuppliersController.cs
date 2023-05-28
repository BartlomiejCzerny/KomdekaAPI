using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KomdekaAPI.Entities;
using KomdekaAPI.Entities.Models;
using Microsoft.AspNetCore.Authorization;

namespace KomdekaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SuppliersController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public SuppliersController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSupplier()
        {
            return await _context.Supplier.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplier(string id)
        {
            var supplier = await _context.Supplier.FindAsync(id);

            if (supplier == null)
            {
                return NotFound("Nie znaleziono dostawcy.");
            }

            return supplier;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(string id, Supplier supplier)
        {
            if (id != supplier.IdNumber)
            {
                return BadRequest("Nie można zmienić numeru identyfikacyjnego dostawcy.");
            }

            _context.Entry(supplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(id))
                {
                    return NotFound("Nie znaleziono dostawcy.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
        {
            _context.Supplier.Add(supplier);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupplierExists(supplier.IdNumber))
                {
                    return BadRequest("Dostawca o podanym numerze identyfikacyjnym istnieje.");
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupplier", new { id = supplier.IdNumber }, supplier);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteSupplier(string id)
        {
            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null)
            {
                return NotFound("Nie znaleziono dostawcy.");
            }

            _context.Supplier.Remove(supplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierExists(string id)
        {
            return _context.Supplier.Any(e => e.IdNumber == id);
        }
    }
}
