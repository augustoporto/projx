using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projx.Models
{
    public class Movimentacao
    {
        [Key]
        public int IdMovimentacao { get; set; }
        public string DscMovimentacao { get; set; }
        public string DscDetalhada {get; set;}
        public char Natureza { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataCriacao { get; set; }
        [ForeignKey("IdCategoriaMovimentacao")]
        public CategoriaMovimentacao Categoria { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
        [ForeignKey("IdConta")]
        public Conta Conta { get; set; }
    }
}