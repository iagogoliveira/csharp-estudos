using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "432.342.523-12";
            cliente.Profissao = "Desenvolvedor";

            

            conta.Saldo = -10;
            conta.Titular = cliente;


            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(cliente.Cpf);
            Console.WriteLine(cliente.Profissao);


            Console.ReadLine();
        }
    }
}