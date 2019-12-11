using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace projx.ViewModels.AgendamentoViewModel
{
    public class EditorAgendamentoViewModel : Notifiable, IValidatable
    {
        public int IdAgendamento { get; set; }
        public int IdMovimentacao { get; set; }
        public char Periodicidade { get; set; }
        public decimal Tempo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool FlgAtivo { get; set;}

        public void Validate()
        {
            if (DataFinal.HasValue)
            {
                AddNotifications(
                    new Contract()
                        .IsGreaterThan(DataFinal.Value, DataInicio, "DataInicio", "A data final deve ser maior que a data inicial.")
                );
            }

            AddNotifications(
                new Contract()
                    .IsGreaterThan(DataInicio, DateTime.Now, "DataInicio", "A data inicial deve ser maior que a data atual")
            );
        }
    }
}