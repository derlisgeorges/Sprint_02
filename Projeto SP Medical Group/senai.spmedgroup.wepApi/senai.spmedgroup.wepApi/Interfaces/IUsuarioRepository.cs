using senai.spmedgroup.wepApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Interfaces
{
    interface IUsuarioRepository
    {

        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Uma lista de Usuarios</returns>
        List<Usuario> Listar();

        /// <summary>
        /// Busca um presença através do ID
        /// </summary>
        /// <param name="id">ID do Usuario que será buscada</param>
        /// <returns>Um Usuario buscado</returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario que será cadastrado</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um Usuario existente
        /// </summary>
        /// <param name="id">ID do Usuario que será buscada</param>
        /// <param name="usuarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int id, Usuario usuarioAtualizado);

        /// <summary>
        /// Deleta uma presença existente
        /// </summary>
        /// <param name="id">ID do usuario será deletado</param>
        void Deletar(int id);


        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Um objeto do tipo Usuario que foi buscado</returns>
        Usuario Login(string email, string senha);
    }
}
