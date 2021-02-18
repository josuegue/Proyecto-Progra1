using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;//varialbe

            Console.WriteLine("Programa que determina si un numero es primo. ");
            Console.Write("\nIngrese un numero: ");
            numero = int.Parse(Console.ReadLine());//guardar un entero 
            //comprobacion y dertermir si el numero es o no primo
            if (numero == 1)
            {
                Console.WriteLine("El numero " + numero + " es primo.");
            }
            else if ((numero % 1 == 0 && numero % numero == 0) && (numero%2!=0))
                    {
                Console.WriteLine("El numero " + numero + " es primo.");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " no es primo.");
            }
        }
    }
}
