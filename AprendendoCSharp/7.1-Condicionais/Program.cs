using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 20;
        int quantidadePessoas = 3;

        if (idade >= 18)
        {
            Console.WriteLine("Você tem mais que 18 anos");
            Console.WriteLine("Seja bem vindo!");
        }
        else
        {
            if(quantidadePessoas > 1)
            {
                Console.WriteLine("Você está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
        }
    }
}