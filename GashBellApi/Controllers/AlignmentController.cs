using AutoMapper;
using GashBellApi.Data;
using GashBellApi.Data.Dtos.Alignment;
using GashBellApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GashBellApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlignmentController : ControllerBase
    {
        private Context _context;
        private IMapper _mapper;

        public AlignmentController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddAlignment([FromBody] CreateAlignmentDto dto)
        {
            Alignment alignment = _mapper.Map<Alignment>(dto);
            _context.Alignments.Add(alignment);
            _context.SaveChanges();
            return CreatedAtAction(nameof(FindAlignmentId), new { Id = alignment.Id }, alignment);
        }
        [HttpGet("{id}")]
        public IActionResult FindAlignmentId(int id)
        {
            Alignment alignment = _context.Alignments.FirstOrDefault(alignment => alignment.Id == id);
            if (alignment != null)
            {
                ReadAlignmentDto alignmentDto = _mapper.Map<ReadAlignmentDto>(alignment);
                return Ok(alignmentDto);
            }
            return NotFound();
        }
        [HttpGet]
        public IEnumerable<Alignment> FindAlignments()
        {
            return _context.Alignments;
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDemon(int id, [FromBody] UpdateAlignmentDto alignmentDto)
        {
            Alignment alignment = _context.Alignments.FirstOrDefault(alignment => alignment.Id == id);
            if (alignment == null) return NotFound();
            _mapper.Map(alignmentDto, alignment);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDemon(int id)
        {
            Alignment alignment = _context.Alignments.FirstOrDefault(alignment => alignment.Id == id);
            if (alignment == null) return NotFound();
            _context.Remove(alignment);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
