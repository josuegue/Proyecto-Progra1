using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Juegos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Dato = dato.Text;
            int numero;
            string copia1 = " ", copia2 = " ";

            numero = int.Parse(Dato);
            numero -= 365;
            copia1 = numero.ToString();
            copia2 = copia1;
            int tamCadena = copia2.Length;
            copia2 = copia2.Substring((tamCadena - 2), 2);
            copia1 = copia1.Remove(copia1.Length - 2);
            

            DisplayAlert("Resultado", "Tienes " + copia1 + " de edad y el mes en el que naciste es " + copia2, "Finalizar");




        }
    }
}