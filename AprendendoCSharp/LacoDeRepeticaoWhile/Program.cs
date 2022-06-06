using System;

class Programa
{
    static void Main(string[] args)
    {
        int contador = 0;
        while(contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}