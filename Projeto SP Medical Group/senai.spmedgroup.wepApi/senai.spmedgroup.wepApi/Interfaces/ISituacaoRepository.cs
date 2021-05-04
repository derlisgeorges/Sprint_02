using senai.spmedgroup.wepApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Interfaces
{
    interface ISituacaoRepository
    {

        List<Situacao> Listar();


        Situacao BuscarPorId(int id);


        void Cadastrar(Situacao novaSituacao);


        void Atualizar(int id, Situacao situacaoAtualizada);


        void Deletar(int id);
    }
}
