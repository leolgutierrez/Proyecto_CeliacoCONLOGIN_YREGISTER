using Proyecto_Celiaco.card_recetas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Proyecto_Celiaco.card;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using SQLitePCL;
using System.IO;
using Microsoft.Data.Sqlite;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]



    public partial class ListaFavoritos : ContentPage
    {
        public ObservableCollection<Receta> recetas { get; set; }
        //public ObservableCollection<Receta> aux_recetas { get; set; }
        public ObservableCollection<ingrediente> lista_ing { get; set; }
        public ObservableCollection<IngredientesXRecetas> lista_ing_rec { get; set; }

        
        public ListaFavoritos()
        {
            InitializeComponent();
            if(session_temp()!= "")
            {
                labeltest.IsVisible = true;
                titulo.Text = "¡Aqui estan sus recetas favoritas!";
                recetas = new ObservableCollection<Receta>();
                lista_ing = new ObservableCollection<ingrediente>();
                lista_ing_rec = new ObservableCollection<IngredientesXRecetas>();
                lista_ing_Recetas lista = new lista_ing_Recetas();
                lista_recetas lista_Recetas = new lista_recetas();
                lista_recetas listafavoritos = new lista_recetas();
                lista_ing_rec = lista.lstrec;
                cargar_recetas_fav(lista_Recetas);
                cargar_cant();
                string dificultad = "";
                ordenar_por_filtro(lista_ing, dificultad, recetas, lista_ing_rec);
                BindingContext = this;

            }
            else
            {
                titulo.Text = "No esta logeado,debe logearse para usar esta funcion 😊";
                labeltest.IsVisible = false;
            } 
            
        }

        

        /*public async void xd()
        {
            using (SqliteConnection db =
                   new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {
                db.Open();
                string comando = "select id_receta from RecetaFav where id_usuario=1"; //un ejemplo de select
                SqliteCommand com = new SqliteCommand(comando, db);
                SqliteDataReader lector = com.ExecuteReader();
                lector.Read();
                int i = 0;
                
            }
        }*/

        public void cargar_recetas_fav(lista_recetas pov)
        {
            
            using (SqliteConnection db =
                   new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {
                try
                {
                    db.Open();
                    string comando = "select id_receta from RecetaFav where id_usuario=" + devolverid(); //un ejemplo de select
                    SqliteCommand com = new SqliteCommand(comando, db);
                    int rowcount = 0;
                    rowcount = Convert.ToInt32(com.ExecuteScalar());
                    SqliteDataReader lector = com.ExecuteReader();


                    //lector.Read();
                    if (!lector.Read())
                    {
                        titulo.Text = "No posee aun recetas favoritas";
                    }
                    while (lector.Read())
                    {
                        int id=lector.GetInt32(0);
                        int j = 0;
                        while (j < pov.lstrec.Count)
                        {
                            if (pov.lstrec[j].receta_id == id)
                            {
                                recetas.Add(pov.lstrec[j]);
                            }
                            j++;
                        }
                        
                    }
                
                    //for (int i = 0; i < rowcount; i++)
                    //{
                    //    int id = Convert.ToInt32(lector.GetValue(i));
                    //    //int id = Convert.ToInt32(lector["id_receta"].);

                    //    DisplayAlert("prueba", id.ToString(), "suppeerr");
                    //    DisplayAlert("SUUPAA", "deberia aparecer", "suppeerr");

                    //    int j = 0;
                    //    while (j < pov.lstrec.Count)
                    //    {
                    //        if (pov.lstrec[j].receta_id == id)
                    //        {
                    //            recetas.Add(pov.lstrec[j]);
                    //        }
                    //        j++;
                    //    }
                    //    titulo.Text = id.ToString();
                    //}
                }
                catch
                {
                    titulo.Text = "No posee aun recetas favoritas";
                }


            }

            

        }



        public async void lv_lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Receta rec_aux = new Receta();
            rec_aux = (Receta)lv_lista.SelectedItem;
            await Navigation.PushModalAsync(new Receta_Detalle(rec_aux));
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
                        cant++;
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
                    if ((recetas[i].cant_user - recetas[i].cant_total_ing < recetas[j].cant_user - recetas[j].cant_total_ing || recetas[i].dif_id != dif_us) && dif_us != 0)
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

        public string session_temp()
        {
            string usuario;
            //ACA SACO LA DIRECC DE LA BDD 
            using (SqliteConnection db =
                new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {
                db.Open();//abro la canilla
                string comando = "select contraseña from usuario where id_usuario=1"; //BUSCO AL USUARIO SESSION
                SqliteCommand cum = new SqliteCommand(comando, db);
                SqliteDataReader leedor = cum.ExecuteReader(); 
                leedor.Read();                                            
                string result = leedor.GetValue(0).ToString();
                if (result != "b")
                {
                    usuario = result;
                    //ENTRO AQUII
                    ; //el primer resultado de una tabla imaginaria
                }
                else
                {
                    usuario = "";
                }
            }
            return usuario;
        }


        
        public string devolverid()
        {
            string a;
            using (SqliteConnection db =
                new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {
                db.Open();//abro la canilla
                string comando = "select id_usuario from usuario where nombre_usuario=(select contraseña from usuario where id_usuario=1)"; //BUSCO AL USUARIO SESSION
                SqliteCommand cum = new SqliteCommand(comando, db);
                SqliteDataReader leedor = cum.ExecuteReader();
                leedor.Read();
                string result = leedor.GetValue(0).ToString();
                a = result;
            }
            return a;

        }


    }
}