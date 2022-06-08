using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoProj
{
    public class Deletar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Deletar(string nome)
        {
            cmd.CommandText = "Delete FROM Funcionarios where nome=@nome";

            cmd.Parameters.AddWithValue("@nome", nome);


            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Deletado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco";
            }

        }

    }
}
