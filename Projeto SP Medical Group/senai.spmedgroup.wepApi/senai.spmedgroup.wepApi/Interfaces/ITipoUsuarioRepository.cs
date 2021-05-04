using senai.spmedgroup.wepApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Interfaces
{
    interface ITipoUsuarioRepository
    { 
        List<TipoUsuario> Listar();

        
        TipoUsuario BuscarPorId(int id);

        
        void Cadastrar(TipoUsuario novoTipoUsuario);


        void Atualizar(int id, TipoUsuario tipousuarioAtualizado);


        void Deletar(int id);
    }
}
