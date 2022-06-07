using System;

namespace BancoProj
{
    class Program
    {
        static void Main(string[] args)
        {
            bool estado = true;

            while (estado)
            {
                string nome = "";
                string idade = "";
                string cargo = "";
                double salario = 0;
                int escolha;

                Console.WriteLine("Seja bem vindo ao banco!");
                Console.WriteLine("Qual operação será efetuada? ");
                Console.WriteLine("1 - Cadastro 2 - Deletar 3 - Consultar tabela 0 - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                        estado = false;
                        break;
                    case 1:
                        Console.WriteLine("Insira o nome do funcionário: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Insira a idade do funcionário: ");
                        idade = Console.ReadLine();


                        Console.WriteLine("Insira o cargo do funcionário: ");
                        cargo = Console.ReadLine();


                        Console.WriteLine("Insira o salario do funcionário: ");
                        salario = Double.Parse(Console.ReadLine());


                        Cadastro novoFuncionario = new Cadastro(nome, idade, cargo, salario);

                        Console.WriteLine(novoFuncionario.mensagem);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Insira o nome do funcionário que será deletado: ");
                        nome = Console.ReadLine();

                        Deletar deletarFuncionario = new Deletar(nome);
                        Console.WriteLine(deletarFuncionario.mensagem);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        VisualizarTabela tabela = new VisualizarTabela();
                        Console.WriteLine(tabela.mensagem);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }
            }
        }
    }
}