using System;
using System.Collections.Generic;

namespace projx.ViewModels.MovimentacaoViewModel
{
    public class ListMovimentacaoViewModel
    {
        public int IdMovimentacao { get; set; }
        public char Natureza { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public string DscCategoria { get; set; }
        public string DscConta { get; set; }
    }
}