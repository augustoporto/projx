using System;
using System.Collections.Generic;

namespace Models
{
    public class Categoria 
    {
        public int IdCategoria { get; set; }
        public string DscCategoria { get; set; }
        public int FlgAtivo { get; set; }

        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
    }
}