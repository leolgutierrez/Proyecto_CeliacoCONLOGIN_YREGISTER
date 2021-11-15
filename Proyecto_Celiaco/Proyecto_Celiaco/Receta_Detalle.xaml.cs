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
    public partial class Receta_Detalle : ContentPage
    {
        public ObservableCollection<Receta> recetas { get; set; }
        //public ObservableCollection<instruccion> instrucciones { get; set; }
        //public ObservableCollection<IngredientesXRecetas> lista_ing { get; set; }
        Receta aux_receta = new Receta();
        public Receta_Detalle(Receta receta)
        {
            aux_receta = receta;
            recetas = new ObservableCollection<Receta>();
            recetas.Add(aux_receta);
            //lista_ing = new ObservableCollection<IngredientesXRecetas>();
            lista_ing_Recetas lista_Ing_Recetas = new lista_ing_Recetas();
            Lista_ingredientes ingredientes = new Lista_ingredientes();
            InitializeComponent();
            CargarIngredientes(lista_Ing_Recetas,ingredientes);
            //instrucciones = new ObservableCollection<instruccion>();
            BindingContext = this;
        }

        private void CargarIngredientes( lista_ing_Recetas lista_Ing_Recetas, Lista_ingredientes ingredientes)
        {
            int i = 0;
            string descripcion = "";
            while (i < lista_Ing_Recetas.lstrec.Count)
            {
                if (aux_receta.receta_id == lista_Ing_Recetas.lstrec[i].receta_id)
                {
                    string nombre = "";
                    int j = 0;
                    while (j < ingredientes.lstrec.Count)
                    {
                        if (lista_Ing_Recetas.lstrec[i].ing_Id == ingredientes.lstrec[j].ing_Id)
                        {
                            nombre += ingredientes.lstrec[j].nombre;
                        }
                        j++;
                    }
                    descripcion += nombre + "   " + lista_Ing_Recetas.lstrec[i].cant + " " + lista_Ing_Recetas.lstrec[i].unidad + "\n";

                }
                i++;
            }
            aux_receta.descp_ing = descripcion;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int aux = aux_receta.receta_id;
            string aux_titulo = aux_receta.nombre;
            string aux_url = aux_receta.url;
            await Navigation.PushModalAsync(new Carrousel_Instrucciones(aux, aux_titulo, aux_url)); 
        }
    }
}