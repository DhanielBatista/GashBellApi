using AutoMapper;
using GashBellApi.Data;
using GashBellApi.Data.Dtos.Demon;
using GashBellApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GashBellApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemonController : ControllerBase
    {
        private Context _context;
        private IMapper _mapper;

        public DemonController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddDemon([FromBody] CreateDemonDto demonDto)
        {
            Demon demon = _mapper.Map<Demon>(demonDto);
            _context.Demons.Add(demon);
            _context.SaveChanges();
            return CreatedAtAction(nameof(FindDemonId), new { Id = demon.Id }, demon);
        }

        [HttpGet("{id}")]
        public IActionResult FindDemonId(int id)
        {
            Demon demon = _context.Demons.FirstOrDefault(demon => demon.Id == id);
            if (demon != null)
            {
                ReadDemonDto demonDto = _mapper.Map<ReadDemonDto>(demon);
                return Ok(demonDto);
            }
            return NotFound();
        }
        [HttpGet]
        public IEnumerable<Demon> FindDemons()
        {
            return _context.Demons;
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDemon(int id, [FromBody] UpdateDemonDto demonDto)
        {
            Demon demon = _context.Demons.FirstOrDefault(demon => demon.Id == id);
            if (demon == null) return NotFound();
            _mapper.Map(demonDto, demon);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDemon(int id)
        {
            Demon demon = _context.Demons.FirstOrDefault(demon => demon.Id == id);
            if(demon == null) return NotFound();
            _context.Remove(demon);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
