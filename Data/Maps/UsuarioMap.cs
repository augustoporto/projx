using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projx.Models;

namespace projx.Data.Maps 
{
    public class UsuarioMap: IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.IdUsuario);
            builder.Property(x => x.NomUsuario).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.DataCriacao).IsRequired();
        }
    }
}
