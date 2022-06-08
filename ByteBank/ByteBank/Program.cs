
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "542.423.543-20";
            carlos.Salario = 2000;

            Funcionario pedro = new Diretor();

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "472.523.752-3";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referencia de diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de funcionario: " + robertaTeste.GetBonificacao());


            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();

        }
    }
}