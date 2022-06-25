
using FilmesAPI.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dto
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public int GerenteId { get; set; }
    }

    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Gerente Gerente { get; set; }
    }
    public class UpdateCinemaDto
    {
        public string Nome { get; set; }
      
    }
}




