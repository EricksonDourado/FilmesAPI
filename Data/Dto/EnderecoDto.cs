using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dto
{
    public class CreateEnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório")]
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }

    public class ReadEnderecoDto
    {
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório")]
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }

    public class UpdateEnderecoDto
    {
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório")]
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}




