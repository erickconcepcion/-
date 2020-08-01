using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd_;
using BackEnd_.Models;

namespace BackEnd_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RubroController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RubroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Rubro
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rubro>>> GetRubro()
        {
            return await _context.Rubro.ToListAsync();
        }

        // GET: api/Rubro/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rubro>> GetRubro(int id)
        {
            var rubro = await _context.Rubro.FindAsync(id);

            if (rubro == null)
            {
                return NotFound();
            }

            return rubro;
        }

        // PUT: api/Rubro/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRubro(int id, Rubro rubro)
        {
            if (id != rubro.Id)
            {
                return BadRequest();
            }

            _context.Entry(rubro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RubroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Rubro
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rubro>> PostRubro(Rubro rubro)
        {
            _context.Rubro.Add(rubro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRubro", new { id = rubro.Id }, rubro);
        }

        // DELETE: api/Rubro/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rubro>> DeleteRubro(int id)
        {
            var rubro = await _context.Rubro.FindAsync(id);
            if (rubro == null)
            {
                return NotFound();
            }

            _context.Rubro.Remove(rubro);
            await _context.SaveChangesAsync();

            return rubro;
        }

        private bool RubroExists(int id)
        {
            return _context.Rubro.Any(e => e.Id == id);
        }
    }
}
