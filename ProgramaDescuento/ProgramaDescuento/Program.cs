using System;

namespace ProgramaDescuento
{
    class Program
    {
        static void Main(string[] args)
        {
            float total; 
            float descuento;
            Console.Write("Ingrese total: Q");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine(total);
            if (total > 300)
            {
                descuento = (total*80)/100;
                Console.WriteLine("Precio total con descuento es Q." + descuento + ".00");
            }
            else 
            {
                Console.WriteLine("No hay descuento precio final de Q." + total + ".00");
            }

        }
    }
}
