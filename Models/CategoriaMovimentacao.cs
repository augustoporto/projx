using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projx.Models
{
    public class CategoriaMovimentacao
    {
        [Key]
        public int IdCategoria { get; set; }
        public string DscCategoria { get; set; }
        public int FlgAtivo { get; set; }

        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
    }
}