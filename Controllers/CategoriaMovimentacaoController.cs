using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projx.Models;
using projx.Repositories;
using projx.ViewModels;
using projx.ViewModels.CategoriaMovimentacaoViewModel;

namespace projx.Controllers
{
    public class CategoriaMovimentacaoController : Controller
    {
        private readonly CategoriaMovimentacaoRepository _repository;

        public CategoriaMovimentacaoController(CategoriaMovimentacaoRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/categoriasmovimentacao")]
        [HttpGet]
        public IEnumerable<ListCategoriaMovimentacaoViewModel> Get()
        {
            return _repository.Get();
        }

        [Route("v1/categoriasmovimentacao/{id}")]
        [HttpGet]
        public CategoriaMovimentacao Get(int id)
        {
            return _repository.Get(id);
        }

        [Route("v1/categoriasmovimentacao/")]
        [HttpPost]
        public ResultViewModel Post([FromBody]EditorCategoriaMovimentacaoViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível cadastrar a Categoria.",
                    Data = model.Notifications
                };
            
            var categoriaMovimentacao = new CategoriaMovimentacao()
            {
                DscCategoria = model.DscCategoria,
                FlgAtivo = model.FlgAtivo
            };

            _repository.Save(categoriaMovimentacao);

            return new ResultViewModel
            {
                Success = true,
                Message = "Categoria cadastrada com sucesso!",
                Data = categoriaMovimentacao
            };
        }
    }
}