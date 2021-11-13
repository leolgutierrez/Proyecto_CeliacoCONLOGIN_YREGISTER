using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proyecto_Celiaco.card;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Paginainicial : ContentPage
    {
        public Paginainicial()
        {
            InitializeComponent();
        }

        private async void botonstart_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());


        }

        private async void botonstart_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new chef_menu());

        }
    }
}