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
        private string Conexao = "Data Source=DESKTOP-A97HKRA\\SQLEXPRESS; initial catalog=T_Peoples; integrated security=true;";

        public List<FuncionarioDomain> Listartodos()
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(Conexao))
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
                            idFuncionario = Convert.ToInt32(rdr["idFuncionario"])
                            ,
                            nome = rdr["nome"].ToString()
                            ,
                            sobrenome = rdr["sobrenome"].ToString()

                        };

                        funcionarios.Add(funcionario);
                    }

                    return funcionarios;
                }

            }
        }
    }
}
