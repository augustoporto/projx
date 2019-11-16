using System;
using System.Collections.Generic;

namespace Models
{
    public class Conta
    {
        public int IdConta {get; set;}
        public string DscConta {get; set;}
        public string TipoConta {get; set;}
        public Usuario Usuario {get; set;}
    }
}