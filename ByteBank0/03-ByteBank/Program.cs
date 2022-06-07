using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;

            Console.WriteLine(contaDaGabriela.saldo);

            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }
            
        }
    }
}