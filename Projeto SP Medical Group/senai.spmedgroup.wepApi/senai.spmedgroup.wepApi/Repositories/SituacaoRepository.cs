using senai.spmedgroup.wepApi.Contexts;
using senai.spmedgroup.wepApi.Domains;
using senai.spmedgroup.wepApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Situacao situacaoAtualizada)
        {
            Situacao SituacaoAntiga = ctx.Situacaos.Find(id);

            if (situacaoAtualizada.Situacao1 !=null)
            {
                SituacaoAntiga.Situacao1 = situacaoAtualizada.Situacao1;
            }
        }

        public Situacao BuscarPorId(int id)
        {
            return ctx.Situacaos.FirstOrDefault(tu => tu.IdSituacao == id);
        }

        public void Cadastrar(Situacao novaSituacao)
        {
            ctx.Situacaos.Add(novaSituacao);


            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Situacao SituacaoBuscada = ctx.Situacaos.Find(id);


            ctx.Situacaos.Remove(SituacaoBuscada);

            ctx.SaveChanges();
        }

        public List<Situacao> Listar()
        {
            return ctx.Situacaos.ToList();
        }
    }
}
