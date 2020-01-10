using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projx.Models;
using projx.Repositories;
using projx.ViewModels;
using projx.ViewModels.UsuarioViewModel;

namespace projx.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly UsuarioRepository _repository;

        public UsuarioController(UsuarioRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/usuarios")]
        [HttpGet]
        public IEnumerable<ListUsuarioViewModel> Get()
        {
            return _repository.Get();
        }

        [Route("1/usuarios/{id}")]
        [HttpGet]
        public Usuario Get(int id)
        {
            return _repository.Get(id);
        }

        [Route("v1/usuarios")]
        [HttpPost]
        public ResultViewModel Post([FromBody]EditorUsuarioViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível cadastrar o usuário.",
                    Data = model.Notifications
                };

            var usuario = new Usuario();
            usuario.Ativo = model.Ativo;
            usuario.DataCriacao = DateTime.Now;
            usuario.IdUsuario = model.IdUsuario;
            usuario.Login = model.Login;
            usuario.NomUsuario = model.NomUsuario;
            usuario.Pswd = model.Pswd;

            _repository.Save(usuario);

            return new ResultViewModel
            {
                Success = true,
                Message = "O usuário foi cadastrado com sucesso.",
                Data = usuario
            };
        }

        [Route("v1/usuarios/{id}")]
        [HttpPut]
        public ResultViewModel Put([FromBody]EditorUsuarioViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Houve um erro na atualização do usuário",
                    Data = model.Notifications
                };

            var usuario = new Usuario();
            usuario.Ativo = model.Ativo;
            usuario.IdUsuario = model.IdUsuario;
            usuario.Login = model.Login;
            usuario.NomUsuario = model.NomUsuario;
            usuario.Pswd = model.Pswd;

            _repository.Update(usuario);

            return new ResultViewModel
            {
                Success = true,
                Message = "Usuário atualizado com sucesso",
                Data = usuario
            };
        }

        [Route("v1/usuarios/{id}")]
        [HttpDelete]
        public ResultViewModel Delete(int id)
        {
            var usuario = _repository.Get(id);

            if (usuario != null)
                if (_repository.Delete(usuario))
                    return new ResultViewModel
                    {
                        Success = true,
                        Message = "Usuário deletado com sucesso.",
                        Data = null
                    };

            return new ResultViewModel
            {
                Success = false,
                Message = "Não foi possível deletar o usuário.",
                Data = usuario != null ? usuario : null
            };
        }
    }
}