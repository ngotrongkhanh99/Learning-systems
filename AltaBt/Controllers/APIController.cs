using AltaBt.DBContext;
using AltaBt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AltaBt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        public readonly DataContext _context;

        public APIController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Class>> Get() => await _context.Classes.ToListAsync();
        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            var Class = await _context.Classes.FindAsync(id);
            return Class == null ? NotFound() : Ok(Class);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Class @class)
        {
            await _context.Classes.AddAsync(@class);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = @class.ClassId }, @class) ;
        }
    }
}
