using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Juegos
{
    public partial class MainPage : ContentPage
    {
     
        public MainPage()
        {
            InitializeComponent();

        }



        private async void buttonpagina1_Clicked(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new Page1());
        }

        private async void buttonOtrapagina_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}




