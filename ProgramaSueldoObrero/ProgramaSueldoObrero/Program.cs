using System;

namespace ProgramaSueldoObrero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcular el sueldo de un obrero, el cual obtine:
             * Si trabaja 40 horas o menos se le paga Q16
             * Si trabaja mas de 40 se le paga Q16 por cada una de las primeras 40 horas
             * y 20 poR CADA hora extra
             */
            int horas;
            const int sueldoVariable = 16;
            int sueldoFinal = 0, contador = 0;
            int horasExtra = 0, finalExtra = 0;
            const int pagoExtra = 20;

            Console.WriteLine("Pago por hora Q.16.00");
            Console.Write("Ingrese horas trabajadas: ");
            horas = int.Parse(Console.ReadLine());//Lee numeros 
            Console.WriteLine("");
            Console.WriteLine("Pago por horas extra Q.20.00");
            Console.Write("Ingrese horas extra: ");
            horasExtra = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (horas <= 40)
            {
                sueldoFinal = horas * sueldoVariable;
                finalExtra = horasExtra * pagoExtra;
                Console.WriteLine("Su sueldo es Q" + sueldoFinal + ".00");
                Console.WriteLine("Su sueldo Extra es Q." + finalExtra + ".00");
            }
            else if (horas >= 40)
            {
                for (int i = 0; i < horas; i++)
                {
                    contador+= sueldoVariable;
                    sueldoFinal = (horas * sueldoVariable) + contador;
                }
                finalExtra = horasExtra * pagoExtra;
                Console.WriteLine("El sueldo es Q." + sueldoFinal + ".00");
                Console.WriteLine("El sueldo extra es Q." + finalExtra + ".00");
            }
            Console.ReadKey();//Evita que el programa se cierre

        }
    }
}
