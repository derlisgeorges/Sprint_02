using senai.spmedgroup.wepApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Interfaces
{
    interface IEspecialidadeRepository
    {

        List<Especialidade> Listar();


         Especialidade BuscarPorId(int id);


        void Cadastrar( Especialidade novaEspecialidade);


        void Atualizar(int id, Especialidade especialidadeAtualizada);


        void Deletar(int id);
    }
}
