using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projx.Models
{
    public class Movimentacao
    {
        [Key]
        public int IdMovimentacao { get; set; }
        public char Natureza { get; set; }
        public decimal Valor { get; set; }
        public CategoriaMovimentacao Categoria { get; set; }
        public Usuario Usuario { get; set; }
        public Conta Conta { get; set; }
    }
}