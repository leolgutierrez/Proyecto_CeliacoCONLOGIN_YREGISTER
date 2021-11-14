using Proyecto_Celiaco.card_recetas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrousel_Instrucciones : ContentPage
    {
        //public class instInformation

        //{

        //    public string _textinst { get; set; }

        //}
        int rec_id = 0;
        public ObservableCollection<instruccion> instrucciones { get; set; }

        public Carrousel_Instrucciones(ObservableCollection<instruccion> pasos)
        {
            
            instrucciones = new ObservableCollection<instruccion>();
            instrucciones = pasos;
            //instrucciones = lista.lstrec;
            //cargarlista(rec_id, instrucciones, lista);
            InitializeComponent();
            BindingContext = this;

        }

        //private void cargarlista(int rec_id, ObservableCollection<instruccion> instrucciones, lista_instrucciones lista_Instrucciones)
        //{
        //    try
        //    {
        //        int i = 0;
        //        while (i < lista_Instrucciones.lstrec.Count)
        //        {
        //            if (lista_Instrucciones.lstrec[i].receta_id == rec_id)
        //            {
        //                instrucciones.Add(lista_Instrucciones.lstrec[i]);
        //            }
        //            i++;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        DisplayAlert(rec_id.ToString(), e.Message, "me mato");
        //    }
        //}
    }
}