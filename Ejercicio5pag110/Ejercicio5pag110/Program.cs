using System;

namespace Ejercicio5pag110
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hacer una programa que pueda calcular
                el perímetro y el área de cualquier
                polígono regular, pero que le pregunte al
                usuario qué desea calcular.
             */
            byte opcion = 0;
            double ancho = 0.00f, largo = 0.00f, perimetro = 0.00f, fbase = 0.00f, alto = 0.00f, area = 0.00f;  
            Console.WriteLine("Ingrese una opcion. \n1.-Calcular el perimetro de un poligono rectangular.\n2.-Calcular el area de un poligono rectangular: ");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1://calculo del perimetro 
                    Console.WriteLine("Ingrese el ancho del poligono rectangular");
                    ancho = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el largo del poligono rectangular");
                    largo = Convert.ToDouble(Console.ReadLine());
                    perimetro = 2 * (ancho + largo);
                    Console.WriteLine($"El perimetro del poligono rectangular es {perimetro}");
                    break;

                case 2://calculo del area
                    Console.WriteLine("Ingrese la base del poligono rectangular");
                    fbase = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del poligono rectangular");
                    alto = Convert.ToDouble(Console.ReadLine());
                    area = fbase * alto;
                    Console.WriteLine($"El area del poligono rectangular es {area}");
                    break;

                default:
                    Console.WriteLine("Ingreso una opcion fuera de rango, intente nuevamente....");
                    break;
            }
            Console.ReadKey();
        }
    }
}
