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
using Microsoft.Data.Sqlite;
using System.IO;

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
            BindingContext = this;
        }

        private void CargarIngredientes(lista_ing_Recetas lista_Ing_Recetas, Lista_ingredientes ingredientes)
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

        private async void butonafavoritos_Clicked(object sender, EventArgs e)
        {
            string a = session_temp();
           
            if (a != "")
            {

                RecetaFav recetaa = new RecetaFav
                {
                    id_usuario = id_usuario(),
                    
                    id_receta = aux_receta.receta_id,

                };
                await DisplayAlert("bb", "bbb", "bbb");

                await App.SQLiteDB.SaveRecetaFav(recetaa);
                await DisplayAlert("cccc", "ccc", "ccc");

            }

            else
            {
                await DisplayAlert("ERROR", "debe logearse para guardar la receta", "ok");
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
                string comando = "select nombre_usuario from usuario where id_usuario=1"; //BUSCO AL USUARIO SESSION
                SqliteCommand cum = new SqliteCommand(comando, db);


                SqliteDataReader leedor = cum.ExecuteReader(); //abro un reader para que sea mas facil el manejo de datos
                                                               // try
                leedor.Read();                                            //{
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

            //}




            return usuario;


        }

        public int id_usuario()
        {
            

            using (SqliteConnection db =
               new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {
                int id;

                db.Open();//abro la canilla
                string comandobuscarnombre = "select nombre_usuario from usuario where id_usuario=1";
                //BUSCO AL USUARIO SESSION
                SqliteCommand zen = new SqliteCommand(comandobuscarnombre, db);
                SqliteDataReader lector = zen.ExecuteReader();
                lector.Read();
                string resultado = lector.GetValue(0).ToString();

                

                string comando = "select id_usuario from usuario where nombre_usuario='" + resultado + "'"; //aca es la consulta del id
                SqliteCommand cum = new SqliteCommand(comando, db);

                SqliteDataReader leedor = cum.ExecuteReader(); //abro un reader para que sea mas facil el manejo de datos                                                             
                leedor.Read();
                string result = leedor.GetValue(0).ToString();

                id = Convert.ToInt32(result);

                return id;







            }








        }
    }
}