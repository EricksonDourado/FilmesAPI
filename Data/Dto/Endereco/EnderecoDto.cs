using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dto
{
    public class CreateEnderecoDto
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }

    public class ReadEnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }

    public class UpdateEnderecoDto
    {        
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório")]
        public int Numero { get; set; }
        public string Bairro { get; set; }     
    }
}




