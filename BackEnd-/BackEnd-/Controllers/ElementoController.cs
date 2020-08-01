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
    public class ElementoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ElementoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Elemento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elemento>>> GetElemento()
        {
            return await _context.Elemento.ToListAsync();
        }

        // GET: api/Elemento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Elemento>> GetElemento(int id)
        {
            var elemento = await _context.Elemento.FindAsync(id);

            if (elemento == null)
            {
                return NotFound();
            }

            return elemento;
        }

        // PUT: api/Elemento/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElemento(int id, Elemento elemento)
        {
            if (id != elemento.Id)
            {
                return BadRequest();
            }

            _context.Entry(elemento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementoExists(id))
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

        // POST: api/Elemento
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Elemento>> PostElemento(Elemento elemento)
        {
            _context.Elemento.Add(elemento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElemento", new { id = elemento.Id }, elemento);
        }

        // DELETE: api/Elemento/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Elemento>> DeleteElemento(int id)
        {
            var elemento = await _context.Elemento.FindAsync(id);
            if (elemento == null)
            {
                return NotFound();
            }

            _context.Elemento.Remove(elemento);
            await _context.SaveChangesAsync();

            return elemento;
        }

        private bool ElementoExists(int id)
        {
            return _context.Elemento.Any(e => e.Id == id);
        }
    }
}
