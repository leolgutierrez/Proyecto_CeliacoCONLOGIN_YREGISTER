using Proyecto_Celiaco.card_recetas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Receta_Detalle : ContentPage
    {
        public Receta_Detalle(Receta receta)
        {
            InitializeComponent();
        }
    }
}