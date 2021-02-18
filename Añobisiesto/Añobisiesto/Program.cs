using System;

namespace Añobisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio = 0;
            
            Console.Write("Ingrese año_____");
            anio = int.Parse(Console.ReadLine());

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0)){
                Console.WriteLine("El año " + anio + " es biciesto");
            }
            else
            {
                Console.WriteLine("El año no es biciesto");
            }
        }
    }
}
