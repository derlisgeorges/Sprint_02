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
        public void Atualizar(int id, Consulta ConsultaAtualizada)
        {
            Consulta ConsultaAntiga = ctx.Consultas.Find(id);

            if (ConsultaAtualizada.IdPaciente !=0)
            {
                ConsultaAntiga.IdPaciente = ConsultaAtualizada.IdPaciente;
            }

            if (ConsultaAtualizada.IdSituacao !=0)
            {
                ConsultaAntiga.IdSituacao = ConsultaAtualizada.IdSituacao;
            }

            if (ConsultaAtualizada.HoraConsulta !=null)
            {
                ConsultaAntiga.HoraConsulta = ConsultaAtualizada.HoraConsulta;
            }

            if (ConsultaAtualizada.DataConsulta !=null)
            {
                ConsultaAntiga.DataConsulta = ConsultaAtualizada.DataConsulta;
            }


        }

        public Consulta BuscarPorId(int id)
        {
            return ctx.Consultas.FirstOrDefault(tu => tu.IdConsulta == id);
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consultas.Add(novaConsulta);


            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Consulta ConsultaBuscado = ctx.Consultas.Find(id);


            ctx.Consultas.Remove(ConsultaBuscado);

            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return ctx.Consultas.ToList();
        }
    }
}
