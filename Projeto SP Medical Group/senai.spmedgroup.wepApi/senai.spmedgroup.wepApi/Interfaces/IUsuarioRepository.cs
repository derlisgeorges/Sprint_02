using senai.spmedgroup.wepApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();


        Usuario BuscarPorId(int id);


        void Cadastrar(Usuario novoUsuario);


        void Atualizar(int id, Usuario usuarioAtualizado);


        void Deletar(int id);

        Usuario Login(string email, string senha);
    }
}
