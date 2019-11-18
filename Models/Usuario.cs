using System;

namespace projx.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Login { get; set; }
        public DateTime DataCriacao {get; set;}
        public string Pswd { get; set; }
        public bool Ativo { get; set; }

    }
}