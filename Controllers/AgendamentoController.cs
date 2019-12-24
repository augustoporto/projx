using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projx.Models;
using projx.Repositories;
using projx.ViewModels;
using projx.ViewModels.AgendamentoViewModel;

namespace projx.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly AgendamentoRepository _repository;

        public AgendamentoController(AgendamentoRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/agendamentos")]
        [HttpGet]
        public IEnumerable<ListAgendamentoViewModel> Get()
        {
            return _repository.Get();
        }


        [Route("v1/agendamentos/{id}")]
        [HttpGet]
        public Agendamento Get(int id)
        {
            return _repository.Get(id);
        }

        [Route("v1/agendamentos/")]
        [HttpPost]
        public ResultViewModel Post([FromBody]EditorAgendamentoViewModel model)
        {
            model.Validate();
            if (model.Invalid)
            {
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível cadastrar o Agendamento.",
                    Data = model.Notifications
                };
            }

            var agendamento = new Agendamento();
            agendamento.DataFinal = model.DataFinal;
            agendamento.DataInicio = model.DataInicio;
            agendamento.FlgAtivo = model.FlgAtivo;
            agendamento.Movimentacao.IdMovimentacao = model.IdMovimentacao;
            agendamento.Periodicidade = model.Periodicidade;
            agendamento.Tempo = model.Tempo;

            _repository.Save(agendamento);

            return new ResultViewModel
            {
                Success = true,
                Message = "Agendamento cadastrado com sucesso.",
                Data = agendamento
            };
        }

        [Route("v1/agendamentos/{id}")]
        [HttpPut]
        public ResultViewModel Put([FromBody]EditorAgendamentoViewModel model)
        {
            model.Validate();
            if (model.Invalid)
            {
                return new ResultViewModel 
                {   
                    Success = false,
                    Message = "Não foi possível atualizar o Agendamento",
                    Data = model.Notifications
                };
            }

            var agendamento = _repository.Get(model.IdAgendamento);
            agendamento.DataFinal = model.DataFinal;
            agendamento.DataInicio = model.DataInicio;
            agendamento.FlgAtivo = model.FlgAtivo;
            agendamento.Movimentacao.IdMovimentacao = model.IdMovimentacao;
            agendamento.Periodicidade = model.Periodicidade;
            agendamento.Tempo = model.Tempo;

            _repository.Update(agendamento);

            return new ResultViewModel
            {
                Success = true,
                Message = "Os dados do agendamento foram alterados com sucesso.",
                Data = agendamento
            };
        }

        [Route("v1/agendamentos/{id}")]
        [HttpDelete]
        public ResultViewModel Delete(int id)
        {
            var agendamento = _repository.Get(id);

            if (_repository.Delete(agendamento))
            {
                return new ResultViewModel
                {
                    Success = true,
                    Message = "O agendamento foi excluída com sucesso.",
                    Data = null
                };
            }
            else
            {
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Houve erro na exclusão do agendamento.",
                    Data = null
                };
            }
        }

    }
}