using System;

namespace projx.Models
{
    public class Agendamento 
    {
        public int IdAgendamento { get; set; }
        public Movimentacao Movimentacao { get; set; }
        public char Periodicidade { get; set; }
        public decimal Tempo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool FlgAtivo { get; set;}

    }
}