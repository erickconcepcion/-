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
    public class ProyectoRubroController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProyectoRubroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProyectoRubro
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoRubro>>> GetProyectoRubro()
        {
            return await _context.ProyectoRubro.ToListAsync();
        }

        // GET: api/ProyectoRubro/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoRubro>> GetProyectoRubro(int id)
        {
            var proyectoRubro = await _context.ProyectoRubro.FindAsync(id);

            if (proyectoRubro == null)
            {
                return NotFound();
            }

            return proyectoRubro;
        }

        // PUT: api/ProyectoRubro/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyectoRubro(int id, ProyectoRubro proyectoRubro)
        {
            if (id != proyectoRubro.Id)
            {
                return BadRequest();
            }

            _context.Entry(proyectoRubro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoRubroExists(id))
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

        // POST: api/ProyectoRubro
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProyectoRubro>> PostProyectoRubro(ProyectoRubro proyectoRubro)
        {
            _context.ProyectoRubro.Add(proyectoRubro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProyectoRubro", new { id = proyectoRubro.Id }, proyectoRubro);
        }

        // DELETE: api/ProyectoRubro/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProyectoRubro>> DeleteProyectoRubro(int id)
        {
            var proyectoRubro = await _context.ProyectoRubro.FindAsync(id);
            if (proyectoRubro == null)
            {
                return NotFound();
            }

            _context.ProyectoRubro.Remove(proyectoRubro);
            await _context.SaveChangesAsync();

            return proyectoRubro;
        }

        private bool ProyectoRubroExists(int id)
        {
            return _context.ProyectoRubro.Any(e => e.Id == id);
        }
    }
}
