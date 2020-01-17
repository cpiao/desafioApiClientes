using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
      
        [Required]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres")]
        public string Bairro { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres")]
        public string Estado { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres")]
        public string Cidade { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}