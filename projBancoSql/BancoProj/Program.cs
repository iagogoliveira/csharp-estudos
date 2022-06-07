namespace BancoProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario andre = new Funcionario();

            andre.Nome = "André";
            andre.Idade = 32;
            andre.Cargo = "Designer";
            andre.Salario = 2500;

            Console.WriteLine("Insira o nome do funcionário: ");
            andre.Nome = Console.ReadLine();

            Console.WriteLine(andre.Idade);
            Console.WriteLine(andre.Cargo);
            Console.WriteLine(andre.Salario);

            Console.ReadLine();
        }
    }
}