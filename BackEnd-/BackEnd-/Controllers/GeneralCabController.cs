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
    public class GeneralCabController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GeneralCabController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GeneralCab
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralCab>>> GetGeneralCab()
        {
            return await _context.GeneralCab.ToListAsync();
        }

        // GET: api/GeneralCab/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralCab>> GetGeneralCab(int id)
        {
            var generalCab = await _context.GeneralCab.FindAsync(id);

            if (generalCab == null)
            {
                return NotFound();
            }

            return generalCab;
        }

        // PUT: api/GeneralCab/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneralCab(int id, GeneralCab generalCab)
        {
            if (id != generalCab.Id)
            {
                return BadRequest();
            }

            _context.Entry(generalCab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneralCabExists(id))
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

        // POST: api/GeneralCab
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GeneralCab>> PostGeneralCab(GeneralCab generalCab)
        {
            _context.GeneralCab.Add(generalCab);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeneralCab", new { id = generalCab.Id }, generalCab);
        }

        // DELETE: api/GeneralCab/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GeneralCab>> DeleteGeneralCab(int id)
        {
            var generalCab = await _context.GeneralCab.FindAsync(id);
            if (generalCab == null)
            {
                return NotFound();
            }

            _context.GeneralCab.Remove(generalCab);
            await _context.SaveChangesAsync();

            return generalCab;
        }

        private bool GeneralCabExists(int id)
        {
            return _context.GeneralCab.Any(e => e.Id == id);
        }
    }
}
