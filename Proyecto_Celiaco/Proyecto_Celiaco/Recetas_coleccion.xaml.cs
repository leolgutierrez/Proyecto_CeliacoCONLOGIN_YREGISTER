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
    public partial class Recetas_coleccion : ContentPage
    {
        public ObservableCollection<Receta> recetas { get; set; }
        //public ObservableCollection<Receta> aux_recetas { get; set; }
        public ObservableCollection<ingrediente> lista_ing { get; set; }
        public ObservableCollection<IngredientesXRecetas> lista_ing_rec { get; set; }
        //public IList<int> lista_cant_usuario { get; set; }
        string dificultad = "";
        public Recetas_coleccion(ObservableCollection<card_recetas.ingrediente> ingredientes,string dif)
        {
            InitializeComponent();
            dificultad = dif;
            //aux_recetas = new ObservableCollection<Receta>();
            recetas = new ObservableCollection<Receta>();
            lista_ing = new ObservableCollection<ingrediente>();
            lista_ing_rec = new ObservableCollection<IngredientesXRecetas>();
            lista_ing_Recetas lista = new lista_ing_Recetas();
            lista_recetas lista_Recetas = new lista_recetas();
            lista_ing_rec = lista.lstrec;
            lista_ing = ingredientes;
            recetas = lista_Recetas.lstrec;
            cargar_cant();
            ordenar_por_filtro(lista_ing,dif,recetas,lista_ing_rec);
            BindingContext = this;
        }

        public void cargar_cant()
        {
            
            foreach (Receta receta in recetas)
            {
                int cant = 0;
                foreach (IngredientesXRecetas ingrediente in lista_ing_rec)
                {
                    if (receta.receta_id == ingrediente.receta_id)
                    {
                        cant ++;
                    }
                }
                receta.cant_total_ing = cant;
            }
        }

        public void ordenar_por_filtro(ObservableCollection<card_recetas.ingrediente> ingredientes, string dif, ObservableCollection<Receta> recetas, ObservableCollection<IngredientesXRecetas> lista_ing_rec)
        {
            int aux = 0;
            //cargo la cantidad de ingredientes del usuario/cantidad de ingredientes de la receta
            foreach (Receta receta in recetas)
            {
                 aux = 0;
                foreach (IngredientesXRecetas ingrec in lista_ing_rec)
                {
                    if (ingrec.receta_id == receta.receta_id)
                    {
                        //DisplayAlert("entro", "entro", "cerrar");
                        foreach (ingrediente ing in ingredientes)
                        {
                            if (ing.ing_Id == ingrec.ing_Id)
                            {
                                aux++;
                            }
                        }
                    }
                }
                receta.cant_user = aux;
                receta.mensaje = aux.ToString() + "/" + receta.cant_total_ing.ToString();
                
            }
            int i = 0;
            int dif_us = 0;
            //traer el id de dif
            switch (dif)
            {
                case "Fácil":
                    dif_us = 1;
                    break;
                case "Intermedio":
                    dif_us = 2;
                    break;
                case "Dificil":
                    dif_us = 3;

                    break;
            }
            //ordenar
            while (i < recetas.Count)
            {
                int j = i + 1;
                while (j < recetas.Count)
                {
                    if ((recetas[i].cant_user- recetas[i].cant_total_ing < recetas[j].cant_user - recetas[j].cant_total_ing || recetas[i].dif_id!=dif_us)&& dif_us!=0)
                    {
                        Receta aux_receta = recetas[i];
                        recetas[i] = recetas[j];
                        recetas[j] = aux_receta;
                    }
                    j++;
                }
                i++;
            }


        }

        public async void lv_lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Receta rec_aux = new Receta();
            rec_aux = (Receta)lv_lista.SelectedItem;
            await Navigation.PushModalAsync(new Receta_Detalle(rec_aux));
        }
    }
}