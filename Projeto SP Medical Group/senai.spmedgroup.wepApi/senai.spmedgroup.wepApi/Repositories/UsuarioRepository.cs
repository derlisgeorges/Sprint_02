using senai.spmedgroup.wepApi.Contexts;
using senai.spmedgroup.wepApi.Domains;
using senai.spmedgroup.wepApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        SpMedGroupContext ctx = new SpMedGroupContext();


        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuario = ctx.Usuarios.Find(id);
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
