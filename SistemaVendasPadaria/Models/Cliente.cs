using System.ComponentModel.DataAnnotations;

namespace SistemaVendasPadaria.Models
{
    public abstract class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [MaxLength(11, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo {0} deve ser preenchido com 11 dígitos numéricos")]
        public string Cpf { get; set; }
        public int Pontos { get; set; }


        public Cliente(int id, string nome, string cpf, int pontos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Pontos = pontos;
        }

        public Cliente() { }

    }
}
