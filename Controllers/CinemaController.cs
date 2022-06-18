using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CinemasAPI.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _autoMapper;

        public CinemaController(FilmeContext context, IMapper autoMapper)
        {
            _context = context;
            _autoMapper = autoMapper;
        }    

        [HttpPost]
        public IActionResult AdicionarCinema([FromBody] CreateCinemaDto cinemaDto)
        {           
            Cinema cinema = _autoMapper.Map<Cinema>(cinemaDto);

            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarCinemasPorId), new { Id = cinema.Id }, cinema);
        }

        [HttpGet]
        public IActionResult ListarTodosCinemas()
        {
            return Ok(_context.Cinemas);          
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCinemasPorId(int id)
        {
           Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            ReadCinemaDto cinemaDto = _autoMapper.Map<ReadCinemaDto>(cinema);
            return Ok(cinemaDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            _autoMapper.Map(cinemaDto, cinema);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCinema(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            _context.Cinemas.Remove(cinema);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
