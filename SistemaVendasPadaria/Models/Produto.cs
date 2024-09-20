using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVendasPadaria.Models
{
    public class Produto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [MaxLength(100)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [Column(TypeName = "double(18.2)")]
        [Display(Name = "Preço")]
        public double preco { get; set; }

    }
}
