using System;

namespace Ejercicio4pag110
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que le pida al usuario
            un número del 1 al 7 y escriba el nombre
            del día que corresponde ese número en la
            semana.
             */
            byte opcion = 0;
            Console.Write("Ingrese un numero del 1-7: ");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Usted selecciono Lunes.");
                    break;
                case 2:
                    Console.WriteLine("Usted selecciono Martes.");
                    break;
                case 3:
                    Console.WriteLine("Usted selecciono Miercoles.");
                    break;
                case 4:
                    Console.WriteLine("Usted selecciono Jueves.");
                    break;
                case 5:
                    Console.WriteLine("Usted selecciono Viernes.");
                    break;
                case 6:
                    Console.WriteLine("Usted selecciono Sabado.");
                    break;
                case 7:
                    Console.WriteLine("Usted selecciono Domingo.");
                    break;
                default:
                    Console.WriteLine("Ha seleccionado un numero incorrecot.\nIntente de nuevo......");
                    break;
            }
        }
    }
}
