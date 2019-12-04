using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projx.Data;
using projx.Models;
using projx.ViewModels.MovimentacaoViewModel;

namespace projx.Repositories.MovimentacaoRepository
{
    public class MovimentacaoRepository
    {
        private readonly MovimentacaoDataContext _context;

        public MovimentacaoRepository(MovimentacaoDataContext context)
        {
            _context = context;
        }

        public IEnumerable<ListMovimentacaoViewModel> Get()
        {
            return _context
                .Movimentacoes
                .Include(x => x.Categoria)
                .Include(x => x.Conta)
                .Select(x => new ListMovimentacaoViewModel
                {
                    IdMovimentacao = x.IdMovimentacao,
                    Natureza = x.Natureza,
                    Valor = x.Valor,
                    DataLancamento = x.DataLancamento,
                    DataCriacao = x.DataCriacao,
                    DscCategoria = x.Categoria.DscCategoria,
                    DscConta = x.Conta.DscConta
                })
                .AsNoTracking()
                .ToList();
        }
        public Movimentacao Get(int id)
        {
            return _context.Movimentacoes.Find(id);
        }
        public void Save(Movimentacao movimentacao)
        {
            _context.Movimentacoes.Add(movimentacao);
            _context.SaveChanges();
        }
        public void Update(Movimentacao movimentacao)
        {
            _context.Entry<Movimentacao>(movimentacao).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}