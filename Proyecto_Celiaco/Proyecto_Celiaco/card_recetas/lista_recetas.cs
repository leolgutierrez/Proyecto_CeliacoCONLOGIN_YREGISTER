using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class lista_recetas
    {
        public ObservableCollection<Receta> lstrec { get; set; }
        public lista_recetas()
        {
            lstrec = new ObservableCollection<Receta>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui iria el la carga de datos de la lista de recetas que se mostraran para seleccionar
        }

    }
}
