using System;

namespace sumanumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.Write("Ingrese letra  ");
            letra = Convert.ToChar(Console.ReadLine());

            
            if (letra>=65 && letra<=90)
            {
                Console.WriteLine("La letra " + letra + " es Mayuscula");
            }
            else
            {
                Console.WriteLine("Es minuscula la letra");
            }
        }
    }
}
