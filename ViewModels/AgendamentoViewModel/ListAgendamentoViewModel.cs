using System;

namespace projx.ViewModels.AgendamentoViewModel
{
    public class ListAgendamentoViewModel
    {
        public int IdAgendamento { get; set; }
        public string DscMovimentacao { get; set; }
        public char Periodicidade { get; set; }
        public decimal Tempo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool FlgAtivo { get; set;}
    }
}