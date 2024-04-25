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
    public class ToolsController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public ToolsController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tool>>> GetTools()
        {
            return await _context.Tool.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tool>> GetTool(string id)
        {
            var tool = await _context.Tool.FindAsync(id);

            if (tool == null)
            {
                return NotFound("Nie znaleziono narzędzia.");
            }

            return tool;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTool(string id, Tool tool)
        {
            if (id != tool.IdNumber)
            {
                return BadRequest("Nie można zmienić numeru identyfikacyjnego narzędzia.");
            }

            _context.Entry(tool).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToolExists(id))
                {
                    return NotFound("Nie znaleziono narzędzia.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Tool>> PostTool(Tool tool)
        {
            _context.Tool.Add(tool);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToolExists(tool.IdNumber))
                {
                    return BadRequest("Narzędzie o podanym numerze identyfikacyjnym istnieje.");
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTool", new { id = tool.IdNumber }, tool);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteTool(string id)
        {
            var tool = await _context.Tool.FindAsync(id);
            if (tool == null)
            {
                return NotFound("Nie znaleziono narzędzia.");
            }

            _context.Tool.Remove(tool);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToolExists(string id)
        {
            return _context.Tool.Any(e => e.IdNumber == id);
        }
    }
}
