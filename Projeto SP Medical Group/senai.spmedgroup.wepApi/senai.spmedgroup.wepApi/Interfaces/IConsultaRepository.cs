using senai.spmedgroup.wepApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Interfaces
{
    interface IConsultaRepository
    {

        List<Consulta> Listar();


        Consulta BuscarPorId(int id);


        void Cadastrar(Consulta novaConsulta);


        void Atualizar(int id, Consulta consultaAtualizada);


        void Deletar(int id);
    }
}
