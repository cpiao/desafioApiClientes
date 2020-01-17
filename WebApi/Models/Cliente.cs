using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Required]
        public string Nome { get; set; }
        
        [Required]
        public string Cpf { get; set; }

        [Required]
        public string DataNascimento { get; set; }

        public virtual Endereco Endereco { get; set; }

        private int _idade;

        [NotMapped]
        public int Idade 
        { 
            get => DateTime.Now.Year - Convert.ToDateTime(DataNascimento).Year;
            set => _idade = 0;
        }
    }
}
