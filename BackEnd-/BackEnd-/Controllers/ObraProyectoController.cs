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
    public class ObraProyectoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ObraProyectoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ObraProyecto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObraProyecto>>> GetObraProyecto()
        {
            return await _context.ObraProyecto.ToListAsync();
        }

        // GET: api/ObraProyecto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ObraProyecto>> GetObraProyecto(int id)
        {
            var obraProyecto = await _context.ObraProyecto.FindAsync(id);

            if (obraProyecto == null)
            {
                return NotFound();
            }

            return obraProyecto;
        }

        // PUT: api/ObraProyecto/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObraProyecto(int id, ObraProyecto obraProyecto)
        {
            if (id != obraProyecto.Id)
            {
                return BadRequest();
            }

            _context.Entry(obraProyecto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObraProyectoExists(id))
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

        // POST: api/ObraProyecto
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ObraProyecto>> PostObraProyecto(ObraProyecto obraProyecto)
        {
            _context.ObraProyecto.Add(obraProyecto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObraProyecto", new { id = obraProyecto.Id }, obraProyecto);
        }

        // DELETE: api/ObraProyecto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ObraProyecto>> DeleteObraProyecto(int id)
        {
            var obraProyecto = await _context.ObraProyecto.FindAsync(id);
            if (obraProyecto == null)
            {
                return NotFound();
            }

            _context.ObraProyecto.Remove(obraProyecto);
            await _context.SaveChangesAsync();

            return obraProyecto;
        }

        private bool ObraProyectoExists(int id)
        {
            return _context.ObraProyecto.Any(e => e.Id == id);
        }
    }
}
