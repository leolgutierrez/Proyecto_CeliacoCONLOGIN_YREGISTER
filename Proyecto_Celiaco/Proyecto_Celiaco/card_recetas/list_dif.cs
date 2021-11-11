using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class list_dif
    {
        public ObservableCollection<Dificultad> lstinst { get; set; }
        public list_dif()
        {
            lstinst = new ObservableCollection<Dificultad>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui la carga de datos en una lista de los instrucciones de una receta x
        }

    }
}
