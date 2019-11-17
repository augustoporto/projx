using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projx.Models;

namespace projx.Data.Maps 
{
    public class ContaMap: IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Conta");
            builder.HasKey(x => x.IdConta);
            builder.Property(x => x.Ativa)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(x => x.DscConta)
                .IsRequired()
                .HasColumnType("varchar(50)");
        }
    }
}
