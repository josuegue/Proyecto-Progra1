using System;

namespace Ejercicio5Pag146
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hacer un programa que calcule el
                promedio de edad de un grupo de
                personas y diga cuál es la de edad más
                grande y cuál es la más joven.
              */
            int cantidad = 0, edadMayor = 0, edadMenor = 0, guardar;
            Console.Write("Digite la cantidad de personas: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <cantidad; i++)
            {
                Console.Write("Ingrese la edad:");
                guardar = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    edadMenor = guardar;
                    edadMayor = guardar;
                }
                if (i != 0)
                {
                    if (guardar > edadMayor)
                    {
                        edadMayor = guardar;
                    }
                    else if (guardar > edadMenor)
                    {
                        edadMenor = guardar;
                    }
                }
            }
            Console.WriteLine($"La edad menor es {edadMenor}");
            Console.WriteLine($"La edad mayor es {edadMayor}");


        }
    }
}
