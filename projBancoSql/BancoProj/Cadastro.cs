using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoProj
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public Cadastro(string nome, string idade, string cargo, double salario)
        {
            //comando sql insert, delete, update
            cmd.CommandText = "insert into Funcionarios (nome, idade, cargo, salario) values (@nome, @idade, @cargo, @salario)";
            //parametros

            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@salario", salario);
            //conectar com banco
            try
            {
                //Conectar com o banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }
            
            //executar comando
            //desconectar
            //mostrar mensagem de erro ou sucesso

        }
    }
}
