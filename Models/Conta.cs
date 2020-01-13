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
        [ForeignKey("IdUsuario")]
        public Usuario Usuario {get; set;}
        public bool Ativa {get; set;}
        public DateTime DataCriacao { get; set; }
        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
    }
}