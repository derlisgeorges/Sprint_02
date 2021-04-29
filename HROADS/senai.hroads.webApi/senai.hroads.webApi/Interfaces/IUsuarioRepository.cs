using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Uma lista de Usuario</returns>
        List<Usuario> Listar();

        /// <summary>
        /// Busca um usuario através do seu ID
        /// </summary>
        /// <param name="id">ID do usuraio que será buscado</param>
        /// <returns>Um usuario buscado</returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo Usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario que será cadastrado</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um Usuario existente
        /// </summary>
        /// <param name="id">ID do Usuario que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto usuarioAtualizado com as novas informações</param>
        void Atualizar(int id, Usuario usuarioAtualizado);

        // <summary>
        /// Deleta um usuario existente
        /// </summary>
        /// <param name="id">ID do usuario que será deletado</param>
        void Deletar(int id);
    }
}
