using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace projx.ViewModels.UsuarioViewModel
{
    public class EditorUsuarioViewModel : Notifiable, IValidatable
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Login { get; set; }
        public string Pswd { get; set; }
        public bool Ativo { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .HasMinLen(NomUsuario, 5, "NomUsuario", "Nome de usuário deve ter pelo menos 5 caracteres.")
                    .HasMinLen(Pswd, 4, "Pswd", "A senha deve ter pelo menos 4 dígitos")
            );
        }
    }
}