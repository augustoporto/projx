using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projx.Data;
using projx.Models;
using projx.ViewModels.AgendamentoViewModel;

namespace projx.Repositories
{
    public class AgendamentoRepository
    {
        private readonly MovimentacaoDataContext _context;

        public AgendamentoRepository(MovimentacaoDataContext context)
        {
            _context = context;
        }

        public IEnumerable<ListAgendamentoViewModel> Get()
        {
            return _context
            .Agendamentos
            .Include(x => x.Movimentacao)
            .Select(x => new ListAgendamentoViewModel
            {
                IdAgendamento = x.IdAgendamento,
                DataInicio = x.DataInicio,
                DataFinal = x.DataFinal,
                FlgAtivo = x.FlgAtivo,
                Periodicidade = x.Periodicidade,
                Tempo = x.Tempo,
                DscMovimentacao = x.Movimentacao.DscMovimentacao
            })
            .AsNoTracking()
            .ToList();
        }
        public Movimentacao Get(int id)
        {
            return _context.Movimentacoes.Find(id);
        }
        public bool Save(Agendamento agendamento)
        {
            _context.Agendamentos.Add(agendamento);
            return _context.SaveChanges() > 0;
        }
        public bool Update(Agendamento agendamento)
        {
            _context.Agendamentos.Update(agendamento);
            return _context.SaveChanges() == 1;
        }
        public bool Delete(Agendamento agendamento)
        {
            _context.Agendamentos.Remove(agendamento);
            return _context.SaveChanges() > 0;
        }
    
    }
}