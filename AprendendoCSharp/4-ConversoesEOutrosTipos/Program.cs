using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;

        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine(salarioInteiro);

        long x;
        x = 2000000000000000000;
        Console.WriteLine(x);

        short y;
        y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);
        // exercicios

        float pontoFlutuante = 3.14f;
        int valor = (int)salario;
        Console.WriteLine(valor);
        double valor1 = 0.2;
        double valor2 = 0.1;
        double total1 = valor1 + valor2;
        Console.WriteLine(total1);





        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}