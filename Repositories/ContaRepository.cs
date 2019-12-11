using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projx.Data;
using projx.Models;
using projx.ViewModels.ContaViewModel;


namespace projx.Repositories
{
    public class ContaRepository
    {
        private readonly MovimentacaoDataContext _context;

        public ContaRepository(MovimentacaoDataContext context)
        {
            _context = context;
        }

        public IEnumerable<ListContaViewModel> Get()
        {
            return _context
                .Contas
                .Include(u => u.Usuario)
                .Select(x => new ListContaViewModel
                {
                    IdConta = x.IdConta,
                    DscConta = x.DscConta,
                    TipoConta = x.TipoConta,
                    NomUsuario = x.Usuario.NomUsuario,
                    Ativa = x.Ativa,
                    DataCriacao = x.DataCriacao
                })
                .AsNoTracking()
                .ToList();
        }

        public Conta Get(int id)
        {
            return _context.Contas.Find(id);
        }

        public bool Save(Conta conta)
        {
            _context.Contas.Add(conta);
            var save = _context.SaveChanges();

            return save > 0;
        }

        public bool Update(Conta conta)
        {
            _context.Contas.Update(conta);
            var update = _context.SaveChanges();

            return update == 1;
        }

        public bool Delete(Conta conta)
        {
            _context.Contas.Remove(conta);
            var deleted = _context.SaveChanges();

            return deleted > 0;
        }

    }
}