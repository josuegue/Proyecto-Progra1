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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Resultado = ingreso.Text;
            int convertidor;
            string final;
            
            Resultado = Resultado.Remove(Resultado.Length - 1);
            convertidor = int.Parse(Resultado);
            convertidor -= 4;
            final = convertidor.ToString();

            
            DisplayAlert("¡Adiviné!\n¿Este es verdad?", final, "Finalizar");



        }
    }
}