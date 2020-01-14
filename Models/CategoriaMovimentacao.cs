using System;
using System.Collections.Generic;

namespace projx.Models
{
    public class CategoriaMovimentacao
    {
        public int IdCategoria { get; set; }
        public string DscCategoria { get; set; }
        public bool FlgAtivo { get; set; }

        //public IEnumerable<Movimentacao> Movimentacoes { get; set; }
    }
}