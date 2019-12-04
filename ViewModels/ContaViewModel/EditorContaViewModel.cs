using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace projx.ViewModels.ContaViewModel
{
    public class EditorContaViewModel : Notifiable, IValidatable
    {
        public int IdConta {get; set;}
        public string DscConta {get; set;}
        public string TipoConta {get; set;}
        public int IdUsuario {get; set;}
        public bool Ativa {get; set;}
        public DateTime DataCriacao { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .HasMaxLen(DscConta, 40, "DscConta", "A descrição deve conter até 40 caracteres")
                    .HasMinLen(DscConta, 2, "DscConta", "A descrição deve conter pelo menos 2 caracteres")
            );
        }
    }
}