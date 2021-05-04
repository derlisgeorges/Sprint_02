using senai.spmedgroup.wepApi.Contexts;
using senai.spmedgroup.wepApi.Domains;
using senai.spmedgroup.wepApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Paciente pacienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public Paciente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Paciente novoPaciente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
