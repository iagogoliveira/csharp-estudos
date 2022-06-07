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
                Console.WriteLine("1 - Cadastro 0 - Sair");
                escolha = int.Parse(Console.ReadLine());

                if(escolha == 0)
                {
                    estado = false;
                }
                else
                {
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
                }
            }
        }
    }
}