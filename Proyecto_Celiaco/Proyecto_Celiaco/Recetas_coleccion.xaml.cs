using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recetas_coleccion : ContentPage
    {
        public Recetas_coleccion(ObservableCollection<card_recetas.ingrediente> ingredientes,string dif)
        {
            InitializeComponent();
        }
    }
}