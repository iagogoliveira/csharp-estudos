using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);


            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            bool resultadoTransferencia = contaDoBruno.Transferir(300, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado transferencia: " + resultadoTransferencia);

            bool resultadoTransferencia2 = contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine("Resultado transferencia: " + resultadoTransferencia2);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDaGabriela.saldo);





        }
    }
}