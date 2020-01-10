using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projx.Data;
using projx.Models;
using projx.ViewModels.UsuarioViewModel;

namespace projx.Repositories
{
    public class UsuarioRepository
    {
        private readonly MovimentacaoDataContext _context;

        public UsuarioRepository(MovimentacaoDataContext context)
        {
            _context = context;
        }

        public IEnumerable<ListUsuarioViewModel> Get()
        {
            return _context
            .Usuarios
            .Select(x => new ListUsuarioViewModel
            {
                Ativo = x.Ativo,
                DataCriacao = x.DataCriacao,
                IdUsuario = x.IdUsuario,
                Login = x.Login,
                NomUsuario = x.NomUsuario,
                Pswd = x.Pswd
            })
            .AsNoTracking()
            .ToList();
        }

        public Usuario Get(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public bool Save(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Usuario usuario)
        {
            _context.Entry<Usuario>(usuario).State = EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            return _context.SaveChanges() > 0;
        }
    }




}