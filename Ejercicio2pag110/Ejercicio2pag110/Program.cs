using System;

namespace Ejercicio2pag110
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que transforme de
            grados a radianes o de radianes a grados
            dependiendo de lo que necesite el
            usuario. 
            1 rad × 180/π = 57.296°
            1° × π/180 = 0.01745rad */
            int n = 0; 
            float radianes = 0f, grados = 0f, conversion = 0f;
            const float numpi= 3.1415f;
            Console.WriteLine("Ingrese opcion:\n1.-Radianes a Grados.\n2.-Grados a Radianes.");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            switch (n)
            {
                case 1:
                    Console.WriteLine("Convertir radianes a grados");
                    Console.Write("Ingrese Radianes: ");
                    radianes = Convert.ToInt32(Console.ReadLine());
                    conversion = radianes * 180 / numpi;
                    Console.WriteLine($"{radianes} radianes equivalen a {conversion} grados.");
                    break;
                case 2:
                    Console.WriteLine("Convertir de grados a radianes");
                    Console.Write("Ingrese grados: ");
                    grados = Convert.ToInt32(Console.ReadLine());
                    conversion = grados * numpi / 180;
                    Console.WriteLine($"{grados} grados equivalen a {conversion} radianes.");
                    break;
                default:
                    Console.WriteLine("Opcion invalida......\nIntente de nuevo.");
                    break;
            }
        }
    }
}
