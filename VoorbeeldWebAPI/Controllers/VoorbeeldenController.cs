using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LinqConsoleApp.Database;
using LinqConsoleApp.Models;

namespace VoorbeeldWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoorbeeldenController : ControllerBase
    {
        private readonly VoorbeeldDBContext _context;

        public VoorbeeldenController(VoorbeeldDBContext context)
        {
            _context = context;
        }

        // GET: api/Voorbeelden
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Voorbeeld>>> GetVoorbeelden()
        {
            return await _context.Voorbeelden.ToListAsync();
        }

        // GET: api/Voorbeelden/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Voorbeeld>> GetVoorbeeld(int id)
        {
            var voorbeeld = await _context.Voorbeelden
                .Include(v => v.Uitwerkingen)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (voorbeeld == null)
            {
                return NotFound();
            }

            return voorbeeld;
        }

    }
}
