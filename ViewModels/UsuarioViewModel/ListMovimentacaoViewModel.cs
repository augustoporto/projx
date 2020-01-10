using System;


namespace projx.ViewModels.UsuarioViewModel
{
    public class ListUsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Login { get; set; }
        public DateTime DataCriacao {get; set;}
        public string Pswd { get; set; }
        public bool Ativo { get; set; }
    }
}