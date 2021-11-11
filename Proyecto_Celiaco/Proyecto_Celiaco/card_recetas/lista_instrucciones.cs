using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class lista_instrucciones
    {
        
        public lista_instrucciones()
        {
           ObservableCollection<instruccion> List_inst = new ObservableCollection<instruccion>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui la carga de datos en una lista de los instrucciones de una receta x
        }

    }
}

