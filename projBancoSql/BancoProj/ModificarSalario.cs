using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoProj
{
    public class ModificarSalario
    {
        public string mensagem = "";
        Conexao conexao = new Conexao();
        public ModificarSalario(string funcionario, string alteracao)
        {
            SqlCommand cmd = new SqlCommand("update Funcionarios set salario = @alteracao where nome = @funcionario");

            cmd.Parameters.AddWithValue("@alteracao", Double.Parse(alteracao));
            cmd.Parameters.AddWithValue("@funcionario", funcionario);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Modificado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco";
            }


        }
    }
}
