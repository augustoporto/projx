using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projx.Models;
using projx.Repositories;
using projx.ViewModels;
using projx.ViewModels.ContaViewModel;


namespace projx.Controllers
{
    public class ContaController : Controller
    {
        private readonly ContaRepository _contaRepository;

        public ContaController(ContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        [Route("v1/contas")]
        [HttpGet]
        public IEnumerable<ListContaViewModel> Get()
        {
            return _contaRepository.Get();
        }

        [Route("v1/contas/{id}")]
        [HttpGet]
        public Conta Get(int id)
        {
            return _contaRepository.Get(id);
        }

        [Route("v1/contas")]
        [HttpPost]
        public ResultViewModel Post([FromBody]EditorContaViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível incluir uma conta.",
                    Data = model.Notifications
                };

            var conta = new Conta();
            conta.Ativa = model.Ativa;
            conta.DataCriacao = DateTime.Now;
            conta.DscConta = model.DscConta;
            conta.TipoConta = model.TipoConta;
            conta.Usuario.IdUsuario = model.IdUsuario;

            _contaRepository.Save(conta);

            return new ResultViewModel
            {
                Success = true,
                Message = "Conta cadastrada com sucesso.",
                Data = conta
            };
        }

        [Route("v1/contas/{id}")]
        [HttpPut]
        public ResultViewModel Put([FromBody]EditorContaViewModel model)
        {
            model.Validate();
            if (model.Invalid)
            {
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível alterar a Conta.",
                    Data = model.Notifications
                };
            }

            var conta = _contaRepository.Get(model.IdConta);
            conta.Ativa = model.Ativa;
            conta.DscConta = model.DscConta;
            conta.TipoConta = model.TipoConta;

            _contaRepository.Update(conta);

            return new ResultViewModel
            {
                Success = true,
                Message = "Os dados da conta foram alterados com sucesso.",
                Data = conta
            };
        }

        [Route("v1/contas/{id}")]
        [HttpDelete]
        public ResultViewModel Delete(Conta conta)
        {
            if (_contaRepository.Delete(conta))
            {
                return new ResultViewModel
                {
                    Success = true,
                    Message = "A conta foi excluída com sucesso.",
                    Data = null
                };
            }
            else
            {
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Houve erro na exclusão da conta.",
                    Data = null
                };
            }
        }
    }
}