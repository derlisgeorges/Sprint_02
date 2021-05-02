using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{

    public class FuncionarioRepository : IFuncionarioRepository
    {
        private string stringConexao = "Data Source=DESKTOP-G2663C3\\SQLEXPRESS; initial catalog=T_Peoples integrated security=true";

        public void Atualizar(int id, FuncionarioDomain funcionarioAtualizar)
        {
            throw new NotImplementedException();
        }

        public FuncionarioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(FuncionarioDomain novoFuncionario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        List<FuncionarioDomain> ListarTodos()
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idFuncionario, nome, sobrenome FROM Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            idFuncionario        = Convert.ToInt32(rdr["idFuncionario"])
                            ,nome                = rdr["nome"].ToString()
                            ,sobrenome           = rdr["sobrenome"].ToString()
                        };

                        funcionarios.Add(funcionario);
                    }
                    return funcionarios;
                }
            }
        }

        List<FuncionarioDomain> IFuncionarioRepository.ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
