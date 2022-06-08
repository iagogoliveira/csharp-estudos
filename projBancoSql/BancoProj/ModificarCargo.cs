using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoProj
{
    public class ModificarCargo
    {
        public string mensagem = "";
        Conexao conexao = new Conexao();
        public ModificarCargo(string funcionario, string alteracao)
        {
            SqlCommand cmd = new SqlCommand("update Funcionarios set cargo = @alteracao where nome = @funcionario");

            cmd.Parameters.AddWithValue("@alteracao", alteracao);
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
