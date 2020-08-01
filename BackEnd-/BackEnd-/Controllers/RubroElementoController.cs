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
    public class RubroElementoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RubroElementoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RubroElemento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RubroElemento>>> GetRubroElemento()
        {
            return await _context.RubroElemento.ToListAsync();
        }

        // GET: api/RubroElemento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RubroElemento>> GetRubroElemento(int id)
        {
            var rubroElemento = await _context.RubroElemento.FindAsync(id);

            if (rubroElemento == null)
            {
                return NotFound();
            }

            return rubroElemento;
        }

        // PUT: api/RubroElemento/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRubroElemento(int id, RubroElemento rubroElemento)
        {
            if (id != rubroElemento.Id)
            {
                return BadRequest();
            }

            _context.Entry(rubroElemento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RubroElementoExists(id))
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

        // POST: api/RubroElemento
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RubroElemento>> PostRubroElemento(RubroElemento rubroElemento)
        {
            _context.RubroElemento.Add(rubroElemento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRubroElemento", new { id = rubroElemento.Id }, rubroElemento);
        }

        // DELETE: api/RubroElemento/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RubroElemento>> DeleteRubroElemento(int id)
        {
            var rubroElemento = await _context.RubroElemento.FindAsync(id);
            if (rubroElemento == null)
            {
                return NotFound();
            }

            _context.RubroElemento.Remove(rubroElemento);
            await _context.SaveChangesAsync();

            return rubroElemento;
        }

        private bool RubroElementoExists(int id)
        {
            return _context.RubroElemento.Any(e => e.Id == id);
        }
    }
}
