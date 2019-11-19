using Flunt.Notifications;
using Flunt.Validations;

namespace projx.ViewModels.CategoriaMovimentacaoViewModel
{
    public class EditorCategoriaMovimentacaoViewModel : Notifiable, IValidatable
    {
        public int IdCategoria { get; set; }
        public string DscCategoria { get; set; }
        public bool FlgAtivo { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .HasMaxLen(DscCategoria, 40, "DscCategoria", "A descrição deve conter até 50 caracteres")
                    .HasMinLen(DscCategoria, 2, "DscCategoria", "A descrição deve conter pelo menos 2 caracteres")
            );
        }
    }
}