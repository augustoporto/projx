using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projx.Models;
using projx.Repositories;
using projx.ViewModels;
using projx.ViewModels.MovimentacaoViewModel;

namespace projx.Controllers
{
    public class MovimentacaoController : Controller
    {
        private readonly MovimentacaoRepository _movimentacaoRepository;
        private readonly CategoriaMovimentacaoRepository _categoriaMovimentacaoRepository;
        private readonly ContaRepository _contaRepository;
        private readonly UsuarioRepository _usuarioRepository;

        
        public MovimentacaoController(MovimentacaoRepository movimentacaoRepository, CategoriaMovimentacaoRepository categoriaMovimentacaoRepository, ContaRepository contaRepository, UsuarioRepository usuarioRepository)
        {
            _movimentacaoRepository = movimentacaoRepository;
            _categoriaMovimentacaoRepository = categoriaMovimentacaoRepository;
            _contaRepository = contaRepository;
            _usuarioRepository = usuarioRepository;
        }

        [Route("v1/movimentacoes")]
        [HttpGet]
        public IEnumerable<ListMovimentacaoViewModel> Get()
        {
            return _movimentacaoRepository.Get();
        }

        [Route("v1/movimentacoes/{id}")]
        [HttpGet]
        public Movimentacao Get(int id)
        {
            return _movimentacaoRepository.Get(id);
        }

        [Route("v1/movimentacoes")]
        [HttpPost]
        public ResultViewModel Post([FromBody]EditorMovimentacaoViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível cadastrar a movimentação.",
                    Data = model.Notifications
                };

            var movimentacao = new Movimentacao();
            movimentacao.Categoria = _categoriaMovimentacaoRepository.Get(model.IdCategoria);
            movimentacao.Conta = _contaRepository.Get(model.IdConta);
            movimentacao.DataCriacao = DateTime.Now;
            movimentacao.DataLancamento = model.DataLancamento;
            movimentacao.Natureza = model.Natureza;
            movimentacao.Usuario = _usuarioRepository.Get(model.IdUsuario);
            movimentacao.Valor = model.Valor;

            _movimentacaoRepository.Save(movimentacao);

            return new ResultViewModel
            {
                Success = true,
                Message = "Movimentação cadastrada com sucesso.",
                Data = movimentacao
            };
        }
        [Route("v1/movimentacoes/{id}")]
        [HttpPut]
        public ResultViewModel Put([FromBody]EditorMovimentacaoViewModel model)
        {
            model.Validate();
            if (model.Invalid)
            {
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível alterar a movimentação",
                    Data = model.Notifications
                };
            }

            var movimentacao = new Movimentacao();
            movimentacao.Categoria.IdCategoria = model.IdCategoria;
            movimentacao.Conta.IdConta = model.IdConta;
            movimentacao.DataLancamento = model.DataLancamento;
            movimentacao.Natureza = model.Natureza;
            movimentacao.Valor = model.Valor;

            _movimentacaoRepository.Update(movimentacao);

            return new ResultViewModel
            {
              Success = true,
              Message = "Movimentação alterada com sucesso.",
              Data = movimentacao  
            };
        }

        [Route("v1/movimentacoes/{id}")]
        [HttpDelete]
        public ResultViewModel Delete(int id)
        {
            var movimentacao = _movimentacaoRepository.Get(id);

            if (movimentacao != null)
            {
                if(_movimentacaoRepository.Delete(movimentacao))
                {
                    return new ResultViewModel
                    {
                        Success = true,
                        Message = "Movimentação deletada com sucesso.",
                        Data = null
                    };
                }
            }

            return new ResultViewModel
            {
                Success = false,
                Message = "Não foi possível encontrar a movimentação que tentou deletar.",
                Data = movimentacao != null ? movimentacao : null
            };
            
        }


    }
}