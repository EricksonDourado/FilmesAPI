using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Cinema
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
}
