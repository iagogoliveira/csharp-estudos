using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas >= 2;
        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }



        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}