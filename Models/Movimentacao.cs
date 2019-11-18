using System;
using System.ComponentModel.DataAnnotations;

namespace projx.Models
{
    public class Movimentacao
    {
        public int IdMovimentacao { get; set; }
        public char Natureza { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public CategoriaMovimentacao Categoria { get; set; }
        public Usuario Usuario { get; set; }
        public Conta Conta { get; set; }
    }
}