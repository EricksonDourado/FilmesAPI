﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dto
{
    public class CreateCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Proprietario { get; set; }
        [StringLength(100, ErrorMessage = "O nome do Proprietário é obrigatorio")]
        public string NomeFantasia { get; set; }
    }

    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public object Endereco { get; set; }
    }

    public class UpdateCinemaDto
    {
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Proprietario { get; set; }
        [StringLength(100, ErrorMessage = "O nome do Proprietário é obrigatorio")]
        public string NomeFantasia { get; set; }
    }
}



