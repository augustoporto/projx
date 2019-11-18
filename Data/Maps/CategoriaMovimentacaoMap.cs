using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projx.Models;

namespace projx.Data.Maps 
{
    public class CategoriaMovimentacaoMap: IEntityTypeConfiguration<CategoriaMovimentacao>
    {
        public void Configure(EntityTypeBuilder<CategoriaMovimentacao> builder)
        {
            builder.ToTable("CategoriaMovimentacao");
            builder.HasKey(x => x.IdCategoria);
            builder.Property(x => x.DscCategoria).IsRequired().HasMaxLength(50);
        }
    }
}
