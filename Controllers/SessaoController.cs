using AutoMapper;
using FilmesAPI;
using FilmesAPI.Data;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        SessaoService _context;
        public SessaoController(SessaoService context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto dto)
        {
            ReadSessaoDto sessao = _context.AdicionaSessao(dto);

            return CreatedAtAction(nameof(RecuperaSessoesPorId), new { Id = sessao.Id }, sessao);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessoesPorId(int id)
        {
            ReadSessaoDto sessaoDto = _context.RecuperaSessoesPorId(id);
            if (sessaoDto != null) { return Ok(sessaoDto); }
            return NotFound();
        }
    }
}
