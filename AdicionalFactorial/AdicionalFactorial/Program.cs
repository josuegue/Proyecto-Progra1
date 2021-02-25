using System;

namespace AdicionalFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //calcular el factorial del un numero 
            int numeroN = 0, contador = 1;
            Console.Write("Ingrese un numero para calcular el factorial: ");
            numeroN = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=numeroN; i++)
            {
                contador *= i;
            }
            Console.WriteLine($"El factorial de {numeroN} es {contador}");

        }
    }
}
