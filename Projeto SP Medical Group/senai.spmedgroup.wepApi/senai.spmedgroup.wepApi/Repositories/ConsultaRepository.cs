using senai.spmedgroup.wepApi.Contexts;
using senai.spmedgroup.wepApi.Domains;
using senai.spmedgroup.wepApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Consulta consultaAtualizada)
        {
            throw new NotImplementedException();
        }

        public Consulta BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> Listar()
        {
            return ctx.Presencas.ToList();
        }
    }
}
