using Proyecto_Celiaco.card_recetas;
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
    public partial class Dificultad : ContentPage
    {
        public ObservableCollection<card_recetas.Dificultad> lista_dif { get; set; }
        public Dificultad()
        {
            InitializeComponent();
            lista_dif = new ObservableCollection<card_recetas.Dificultad>();
            list_dif lista = new list_dif();
            lista_dif = lista.lstinst;
            BindingContext = this;
        }

        private async void lv_lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            card_recetas.Dificultad aux= (card_recetas.Dificultad)lv_lista.SelectedItem;
            await Navigation.PushModalAsync(new ing_filtro(aux.tipo));
        }
        //volver a chef menu
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new chef_menu());
        }
        //ir sin dificultad
        private async void btn_avanzar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ing_filtro(""));
        }
    }
}