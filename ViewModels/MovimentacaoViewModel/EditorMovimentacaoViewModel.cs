using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace projx.ViewModels.MovimentacaoViewModel
{
    public class EditorMovimentacaoViewModel : Notifiable, IValidatable
    {
        public int IdMovimentacao { get; set; }
        public char Natureza { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public int IdCategoria { get; set; }
        public int IdUsuario { get; set; }
        public int IdConta { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .IsLowerOrEqualsThan(Valor, 0, "Valor", "O valor da movimentação deve ser maior que 0.")
            );
        }
    }
}