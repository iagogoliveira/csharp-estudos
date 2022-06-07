using System;

namespace _07_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 87623432);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 8674589);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
        }
    }
}