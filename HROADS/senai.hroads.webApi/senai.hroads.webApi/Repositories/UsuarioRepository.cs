using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Usuario UsuarioAtualizado)
        {
            Usuario UsuarioAntigo = ctx.Usuarios.Find(id);

            if (UsuarioAtualizado.IdUsuario != 0)
            {
                UsuarioAntigo.IdUsuario = UsuarioAtualizado.IdUsuario;
            }

            if (UsuarioAtualizado.IdTipoUsuario != null)
            {
                UsuarioAntigo.IdTipoUsuario = UsuarioAtualizado.IdTipoUsuario;
            }

            if (UsuarioAtualizado.Email != null)
            {
                UsuarioAntigo.Email = UsuarioAtualizado.Email;
            }

            if (UsuarioAtualizado.Senha != null)
            {
                UsuarioAntigo.Senha = UsuarioAtualizado.Senha;
            }

            ctx.Usuarios.Update(UsuarioAntigo);

            ctx.SaveChanges();

        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
