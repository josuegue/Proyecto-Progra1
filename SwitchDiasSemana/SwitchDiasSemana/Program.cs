using System;
using System.Globalization;

namespace SwitchDiasSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            Console.Write("Ingrese Dia de la semana:  ");
            opcion =  Console.ReadLine();
            opcion = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(opcion));
            switch (opcion)
            {
                case "Lunes":Console.WriteLine("Dia Laboral");
                    break;
                case "Martes":Console.WriteLine("Dia Laboral");
                    break;
                case "Miercoles":Console.WriteLine("Dia Laboral");
                    break;
                case "Jueves":Console.WriteLine("Dia Laboral");
                    break;
                case "Viernes":Console.WriteLine("Dia Laboral");
                    break;
                case "Sabado":Console.WriteLine("Dia No Laboral");
                    break;
                case "Domingo":Console.WriteLine("Dia No Laboral");
                    break;
                default:
                    Console.WriteLine("Error....Ingrese un dia de la semana");
                    break;



            }
        }
    }
}
