using System;

namespace Ejercicio1Pag146
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hacer un programa que muestre la tabla
                de multiplicar del 1 al 10 de cualquier
                número.
             */
            for (int i=0; i<=10; i++)
            {
                for (int j=0; j<=10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("");
            }
        }
    }
}
