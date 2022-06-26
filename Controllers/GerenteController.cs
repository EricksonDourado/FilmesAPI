using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        GerenteService _gerenteService;
        public GerenteController(GerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto dto)
        {
            ReadGerenteDto readGerenteDto = _gerenteService.AdicionaGerente(dto);
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { Id = readGerenteDto.Id }, readGerenteDto);
        }

        [HttpGet]
        public IActionResult RetornaGerentes()
        {
            List<ReadGerenteDto> readGerenteDto = _gerenteService.RetornaGerentes();

            return Ok(readGerenteDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id)
        {
            ReadGerenteDto readGerenteDto = _gerenteService.RecuperaGerentesPorId(id);
            if (readGerenteDto == null) return NotFound();
            return Ok(readGerenteDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id)
        {
            bool readGerenteDto = _gerenteService.DeletaGerente(id);
            if (!readGerenteDto) return NotFound();
            return NoContent();
        }
    }
}
