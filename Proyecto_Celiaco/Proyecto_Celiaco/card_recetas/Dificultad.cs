using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Proyecto_Celiaco.card_recetas
{
    public class Dificultad
    {
        [PrimaryKey, AutoIncrement]
        public int dif_id { get; set; }
        [MaxLength(80)]
        //dificultad,mediano o facil
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public Color color_dif { get; set; }
    }
}
