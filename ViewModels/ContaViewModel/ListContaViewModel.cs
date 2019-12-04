using System;
using System.Collections.Generic;

namespace projx.ViewModels.ContaViewModel
{
    public class ListContaViewModel
    {
        public int IdConta {get; set;}
        public string DscConta {get; set;}
        public string TipoConta {get; set;}
        public string NomUsuario {get; set;}
        public DateTime DataCriacao {get; set;}
        public bool Ativa {get; set;}
    }
}