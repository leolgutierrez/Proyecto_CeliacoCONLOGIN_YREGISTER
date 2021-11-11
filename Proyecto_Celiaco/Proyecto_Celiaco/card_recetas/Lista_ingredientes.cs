using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class Lista_ingredientes
    {
        public ObservableCollection<ingrediente> lstrec { get; set; }
        public Lista_ingredientes()
        {
            lstrec = new ObservableCollection<ingrediente>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui iria el la carga de datos de la lista de ingredientes que se mostraran para seleccionar
        }
    }
}
