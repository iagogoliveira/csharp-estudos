using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoProj
{
    public class VisualizarTabela
    {
        Conexao conexao = new Conexao();
        public string mensagem = "";

        public VisualizarTabela()
        {
            SqlCommand cmd  = new SqlCommand("SELECT nome FROM Funcionarios");

            try
            {
                //Conectando com o banco
                cmd.Connection = conexao.conectar();
                //Executando a leitura da tabela
                SqlDataReader dr = cmd.ExecuteReader();
                //Loop onde para cada nome encontrado na tabela, será mostrado no cmd.
                //Enquanto dr (SqlDataReader) for true, cmd.ExecuteReader irá ler cada item da tabela na coluna "nome"
                while (dr.Read())
                {
                    Console.WriteLine(dr["nome"].ToString());
                }
                //Fechar a leitura
                dr.Close();
                //Desconectar do banco
                conexao.desconectar();
                //Mensagem de sucesso na operação
                this.mensagem = "Consulta efetudada com sucesso";
            }
            catch (Exception)
            {
                this.mensagem = "Erro ao se conectar ao banco de dados";
            }
        }
    }
}
