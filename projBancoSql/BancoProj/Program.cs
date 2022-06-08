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
                string mod = "";
                string nomeMod = "";
                string campoMod;
                int escolha;

                Console.WriteLine("Seja bem vindo ao banco!");
                Console.WriteLine("Qual operação será efetuada? ");
                Console.WriteLine("1 - Cadastro 2 - Deletar 3 - Consultar tabela 4 - Modificar Salario 5 - Modificar Cargo 0 - Sair");
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
                    case 4:
                        Console.WriteLine("Insira o nome do funcionário que será modificado: ");
                        nomeMod = Console.ReadLine();
                        Console.WriteLine("Insira a modificação: ");
                        mod = Console.ReadLine();
                        ModificarSalario modificar = new ModificarSalario(nomeMod, mod);
                        Console.WriteLine(modificar.mensagem);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Insira o nome do funcionário que será promovido/rebaixado: ");
                        nomeMod = Console.ReadLine();
                        Console.WriteLine("Insira a modificação: ");
                        mod = Console.ReadLine();
                        ModificarCargo modificarCargo = new ModificarCargo(nomeMod, mod);
                        Console.WriteLine(modificarCargo.mensagem);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }
            }
        }
    }
}