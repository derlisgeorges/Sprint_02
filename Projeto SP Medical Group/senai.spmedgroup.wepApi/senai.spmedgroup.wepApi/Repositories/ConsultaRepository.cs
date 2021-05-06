using Microsoft.EntityFrameworkCore;
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

            if (ConsultaAtualizada.DataConsulta >DateTime.Now)
            {
                ConsultaAntiga.DataConsulta = ConsultaAtualizada.DataConsulta;
            }

            if (ConsultaAtualizada.Descricao !=null)
            {
                ConsultaAntiga.Descricao = ConsultaAntiga.Descricao;
            }

            if (ConsultaAtualizada.Descricao == null)
            {
                ConsultaAntiga.Descricao = ConsultaAntiga.Descricao;
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
            Consulta ConsultaAntiga = ctx.Consultas.Find(id);


            ctx.Consultas.Remove(ConsultaAntiga);

            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return ctx.Consultas.ToList();
        }
        public List<Consulta> ListarMinhas(int id)
        {
            // Retorna uma lista com todas as informações das presenças
            return ctx.Consultas
                // Adiciona na busca as informações do evento que o usuário participa
                .Include(p => p.IdMedicoNavigation)
                // Adiciona na busca as informações do Tipo de Evento (categoria) deste evento
                .Include(p => p.IdPacienteNavigation)
                // Adiciona na busca as informações da Instituição deste evento
                .Include(p => p.IdSituacaoNavigation)
                // Estabelece como parâmetro de consulta o ID do usuário recebido
                .Where(p => p.IdConsulta == id)
                .ToList();
        }

        public void AlterStatus(int id, string ConsultaPermissao)
        {
            Consulta ConsultaAntiga = ctx.Consultas

                .Include(p => p.IdMedicoNavigation)

                .Include(p => p.IdPacienteNavigation)

                .Include(p => p.IdSituacaoNavigation)

                .FirstOrDefault(p => p.IdConsulta == id);

            switch (ConsultaPermissao)
            {
                case "1":
                    ConsultaAntiga.IdSituacao = 1;
                    break;

                case "2":
                    ConsultaAntiga.IdSituacao = 2;
                    break;

                case "3":
                    ConsultaAntiga.IdSituacao = 3;
                    break;

                default:
                    ConsultaAntiga.IdSituacao = ConsultaAntiga.IdSituacao;
                    break;
            }

            ctx.Consultas.Update(ConsultaAntiga);

            ctx.SaveChanges();
        }

        public void Prontuario(int id, Consulta novoProntuario)
        {
            Consulta ConsultaAntiga = ctx.Consultas.Find(id);

            if (novoProntuario.Descricao != null)
            {
                ConsultaAntiga.Descricao = novoProntuario.Descricao;
            }

            ctx.Consultas.Update(ConsultaAntiga);

            ctx.SaveChanges();
        }

    }
}
