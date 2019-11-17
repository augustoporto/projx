using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projx.Models;

namespace projx.Data.Maps 
{
    public class AgendamentoMap: IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");
            builder.HasKey(x => x.IdAgendamento);
        }
    }
}
