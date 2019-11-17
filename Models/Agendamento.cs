using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projx.Models
{
    public class Agendamento 
    {
        [Key]
        public int IdAgendamento { get; set; }
        public Movimentacao Movimentacao { get; set; }
        public char Periodicidade { get; set; }
        public decimal Tempo { get; set; }
        public bool FlgAtivo { get; set;}

    }
}