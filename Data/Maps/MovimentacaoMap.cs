using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projx.Models;

namespace projx.Data.Maps 
{
    public class MovimentacaoMap: IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.ToTable("Movimentacao");
            builder.HasKey(x => x.IdMovimentacao);
            builder.Property(x => x.Natureza).IsRequired();
            builder.Property(x => x.Valor).IsRequired().HasColumnType("money");
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataLancamento).IsRequired();
            builder.HasOne(x => x.Conta).WithMany(x => x.Movimentacoes);
        }
    }
}
