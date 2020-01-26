using Microsoft.EntityFrameworkCore;
using projx.Models;
using projx.Data.Maps;

namespace projx.Data
{
    public class MovimentacaoDataContext : DbContext
    {
        public DbSet<Conta> Contas {get; set;}
        public DbSet<CategoriaMovimentacao> CategoriaMovimentacoes {get; set;}
        public DbSet<Movimentacao> Movimentacoes {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Agendamento> Agendamentos { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Deve-se adicionar a package Microsoft.EntityFrameworkCore.SqlServer para aparecer a optionbuilder 'UseSqlServer'
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=fnctrl;User ID=SA;Password=123456");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
             builder.ApplyConfiguration(new MovimentacaoMap());
             builder.ApplyConfiguration(new ContaMap());
             builder.ApplyConfiguration(new AgendamentoMap());
             builder.ApplyConfiguration(new CategoriaMovimentacaoMap());
             builder.ApplyConfiguration(new UsuarioMap());
        }
    }
}