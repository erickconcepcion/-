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
    public class ElementoPrecioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ElementoPrecioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ElementoPrecio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElementoPrecio>>> GetElementoPrecio()
        {
            return await _context.ElementoPrecio.ToListAsync();
        }

        // GET: api/ElementoPrecio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElementoPrecio>> GetElementoPrecio(int id)
        {
            var elementoPrecio = await _context.ElementoPrecio.FindAsync(id);

            if (elementoPrecio == null)
            {
                return NotFound();
            }

            return elementoPrecio;
        }

        // PUT: api/ElementoPrecio/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElementoPrecio(int id, ElementoPrecio elementoPrecio)
        {
            if (id != elementoPrecio.Id)
            {
                return BadRequest();
            }

            _context.Entry(elementoPrecio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementoPrecioExists(id))
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

        // POST: api/ElementoPrecio
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ElementoPrecio>> PostElementoPrecio(ElementoPrecio elementoPrecio)
        {
            _context.ElementoPrecio.Add(elementoPrecio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElementoPrecio", new { id = elementoPrecio.Id }, elementoPrecio);
        }

        // DELETE: api/ElementoPrecio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElementoPrecio>> DeleteElementoPrecio(int id)
        {
            var elementoPrecio = await _context.ElementoPrecio.FindAsync(id);
            if (elementoPrecio == null)
            {
                return NotFound();
            }

            _context.ElementoPrecio.Remove(elementoPrecio);
            await _context.SaveChangesAsync();

            return elementoPrecio;
        }

        private bool ElementoPrecioExists(int id)
        {
            return _context.ElementoPrecio.Any(e => e.Id == id);
        }
    }
}
