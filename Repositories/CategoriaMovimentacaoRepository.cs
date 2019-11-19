using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projx.Data;
using projx.Models;
using projx.ViewModels.CategoriaMovimentacaoViewModel;

namespace projx.Repositories
{
    public class CategoriaMovimentacaoRepository
    {
        private readonly MovimentacaoDataContext _context;

        public CategoriaMovimentacaoRepository(MovimentacaoDataContext context)
        {
            _context = context;
        }

        public IEnumerable<ListCategoriaMovimentacaoViewModel> Get()
        {
            return _context
                .CategoriaMovimentacoes
                .Select(x => new ListCategoriaMovimentacaoViewModel
                {
                    IdCategoria = x.IdCategoria,
                    DscCategoria = x.DscCategoria,
                    FlgAtivo = x.FlgAtivo
                })
                .AsNoTracking()
                .ToList();
        }
        public CategoriaMovimentacao Get(int id)
        {
            return _context.CategoriaMovimentacoes.Find(id);
        }
        public void Save(CategoriaMovimentacao product)
        {
            _context.CategoriaMovimentacoes.Add(product);
            _context.SaveChanges();
        }
        public void Update(CategoriaMovimentacao product)
        {
            _context.Entry<CategoriaMovimentacao>(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}