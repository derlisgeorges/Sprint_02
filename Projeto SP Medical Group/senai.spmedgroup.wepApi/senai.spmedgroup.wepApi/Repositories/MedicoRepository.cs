using senai.spmedgroup.wepApi.Contexts;
using senai.spmedgroup.wepApi.Domains;
using senai.spmedgroup.wepApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Medico medicoAtualizado)
        {
            throw new NotImplementedException();
        }

        public Medico BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Medico novoMedico)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Medico> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
