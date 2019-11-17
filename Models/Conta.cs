using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projx.Models
{
    public class Conta
    {
        [Key]
        public int IdConta {get; set;}
        public string DscConta {get; set;}
        public string TipoConta {get; set;}
        public Usuario Usuario {get; set;}
        public string Ativa {get; set;}
        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
    }
}