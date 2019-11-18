using System.Collections.Generic;

namespace projx.Models
{
    public class Conta
    {
        public int IdConta {get; set;}
        public string DscConta {get; set;}
        public string TipoConta {get; set;}
        public Usuario Usuario {get; set;}
        public string Ativa {get; set;}
        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
    }
}