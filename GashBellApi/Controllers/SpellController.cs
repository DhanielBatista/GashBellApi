using AutoMapper;
using GashBellApi.Data;
using GashBellApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GashBellApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpellController : ControllerBase
    {
        private Context _context;
        private IMapper _mapper;

        public SpellController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddSpell([FromBody] CreateSpellDto dto)
        {
            Spell spell = _mapper.Map<Spell>(dto);
            _context.Spells.Add(spell);
            _context.SaveChanges();
            return CreatedAtAction(nameof(FindSpellId), new { Id = spell.Id }, spell);
        }
        [HttpGet("{id}")]
        public IActionResult FindSpellId(int id)
        {
            Spell spell = _context.Spells.FirstOrDefault(alignment => alignment.Id == id);
            if (spell != null)
            {
                ReadSpellDto alignmentDto = _mapper.Map<ReadSpellDto>(spell);
                return Ok(alignmentDto);
            }
            return NotFound();
        }
        [HttpGet]
        public IEnumerable<Spell> FindSpells()
        {
            return _context.Spells;
        }
        [HttpPut("{id}")]
        public IActionResult UpdateSpell(int id, [FromBody] UpdateSpellDto dto)
        {
            Spell spell = _context.Spells.FirstOrDefault(spell => spell.Id == id);
            if (spell == null) return NotFound();
            _mapper.Map(dto, spell);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSpell(int id)
        {
            Spell spell = _context.Spells.FirstOrDefault(spell => spell.Id == id);
            if (spell == null) return NotFound();
            _context.Remove(spell);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

