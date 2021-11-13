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
    public partial class ing_filtro : ContentPage
    {
        string aux_dif = "";
        public ObservableCollection<card_recetas.ingrediente> lista_ing { get; set; }
        public ObservableCollection<card_recetas.ingrediente> lista_aux { get; set; }
        public ing_filtro(string dif)
        {
            InitializeComponent();
            aux_dif = dif;
            lista_ing = new ObservableCollection<card_recetas.ingrediente>();
            lista_aux = new ObservableCollection<card_recetas.ingrediente>();
            Lista_ingredientes lista = new Lista_ingredientes();
            lista_ing = lista.lstrec;
            BindingContext = this;
        }
        //volver 
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new chef_menu());
        }
        
        private void lv_lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            lbl_canasta.Text += ((ingrediente)lv_lista.SelectedItem).nombre + " ,";
            lista_aux.Add((ingrediente)lv_lista.SelectedItem);
        }
        //siguiente
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Recetas_coleccion(lista_aux,aux_dif));
        }
    }
}