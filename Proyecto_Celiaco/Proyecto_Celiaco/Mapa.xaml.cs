using Proyecto_Celiaco.card;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {
        //conexion a bdd
        static Sqlitehelper db;
        //funcion para retornar lista de direcciones
        public ObservableCollection<Direcciones> list_direcciones { get; private set; }
        ObservableCollection<Direcciones> aux_direcciones = new ObservableCollection<Direcciones>();
        public static Sqlitehelper sqlitedb
        {
            get
            {
                if (db == null)
                {
                    db = new Sqlitehelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db"));
                }
                return db;
            }
        }
        public Mapa()
        {
            InitializeComponent();
            pkOpciones.Items.Add("Restaurantes");
            pkOpciones.Items.Add("Panaderias");
            pkOpciones.Items.Add("Bares");
            pkOpciones.Items.Add("Tiendas");
            pkOpciones.Items.Add("Todos");
            list_direcciones = new ObservableCollection<Direcciones>();
            DirViewModel dir = new DirViewModel();
            list_direcciones = dir.lstDir;
            aux_direcciones = dir.lstDir;
            BindingContext = this;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Direcciones dir_sel = new Direcciones();
            dir_sel = (Direcciones)lv_lista.SelectedItem;
            await Map.OpenAsync(dir_sel.latitud, dir_sel.longitud, new MapLaunchOptions
            {
                NavigationMode = NavigationMode.None
            });
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
        public void filtrar()
        {
            if (!pkOpciones.Items[pkOpciones.SelectedIndex].Equals("Todos"))
            {
                DirViewModel dir = new DirViewModel();
                aux_direcciones = dir.lstDir;
                ObservableCollection<Direcciones> aux_list = new ObservableCollection<Direcciones>();
                String tipo = pkOpciones.Items[pkOpciones.SelectedIndex];
                int i = 0;
                while (i < aux_direcciones.Count)
                {
                    if (aux_direcciones[i].tipo_local.Equals(tipo))
                    {
                        aux_list.Add(aux_direcciones[i]);


                    }
                    i++;
                }

                list_direcciones.Clear();
                i = 0;
                while (i < aux_list.Count)
                {
                    list_direcciones.Add(aux_list[i]);
                    i++;
                }
                aux_list.Clear();
            }
            else
            {
                DirViewModel dir = new DirViewModel();
                list_direcciones.Clear();
                int i = 0;
                while (i < dir.lstDir.Count)
                {
                    list_direcciones.Add(dir.lstDir[i]);
                    i++;
                }
            }

        }
        private void pkOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            filtrar();
            //lv_lista.ItemsSource = "{Binding list_direcciones}";
            BindingContext = this;
        }

        
    }
}