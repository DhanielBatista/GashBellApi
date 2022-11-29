using AutoMapper;
using GashBellApi.Data;
using GashBellApi.Data.Dtos.Human;
using GashBellApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GashBellApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanController : ControllerBase
    {
        private Context _context;
        private IMapper _mapper;

        public HumanController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddHuman([FromBody] CreateHumanDto humanDto)
        {
            Human human = _mapper.Map<Human>(humanDto);
            _context.Humans.Add(human);
            _context.SaveChanges();
            return CreatedAtAction(nameof(FindHumansId), new { Id = human.Id }, human);
        }
        [HttpGet]
        public IEnumerable<Human> FindHumans()
        {
            return _context.Humans;
        }
        [HttpGet("{id}")]
        public IActionResult FindHumansId(int id)
        {
            Human human = _context.Humans.FirstOrDefault(human => human.Id == id);
            if(human != null)
            {
                ReadHumanDto humanDto = _mapper.Map<ReadHumanDto>(human);
                return Ok(humanDto);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateHuman(int id, [FromBody] UpdateHumanDto humanDto)
        {
            Human human = _context.Humans.FirstOrDefault(human =>human.Id == id);
            if(human == null)
            {
                return NotFound();
            }
            _mapper.Map(humanDto, human);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHuman(int id)
        {
            Human human = _context.Humans.FirstOrDefault(human =>human.Id == id);
            if(human ==  null)
            {
                return NotFound();
            }
            _context.Remove(human);
            _context.SaveChanges();
            return NoContent();
        }


        
    }
}
