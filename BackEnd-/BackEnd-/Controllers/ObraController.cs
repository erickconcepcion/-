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
    public class ObraController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ObraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Obra
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Obra>>> GetObra()
        {
            return await _context.Obra.ToListAsync();
        }

        // GET: api/Obra/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Obra>> GetObra(int id)
        {
            var obra = await _context.Obra.FindAsync(id);

            if (obra == null)
            {
                return NotFound();
            }

            return obra;
        }

        // PUT: api/Obra/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObra(int id, Obra obra)
        {
            if (id != obra.Id)
            {
                return BadRequest();
            }

            _context.Entry(obra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObraExists(id))
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

        // POST: api/Obra
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Obra>> PostObra(Obra obra)
        {
            _context.Obra.Add(obra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObra", new { id = obra.Id }, obra);
        }

        // DELETE: api/Obra/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Obra>> DeleteObra(int id)
        {
            var obra = await _context.Obra.FindAsync(id);
            if (obra == null)
            {
                return NotFound();
            }

            _context.Obra.Remove(obra);
            await _context.SaveChangesAsync();

            return obra;
        }

        private bool ObraExists(int id)
        {
            return _context.Obra.Any(e => e.Id == id);
        }
    }
}
