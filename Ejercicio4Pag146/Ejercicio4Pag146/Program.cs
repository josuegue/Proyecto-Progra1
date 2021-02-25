using System;

namespace Ejercicio4Pag146
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hacer un programa que encuentre los
                números primos que existen entre el 1 y
                el 1000. */
            int numeroPrimo = 1000;
            for (int i=1; i<=numeroPrimo; i++)
            {
                 if ((i % 1 == 0 && i % i == 0) && (i % 2 != 0 && i%3!=0) && i % 5!=0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
