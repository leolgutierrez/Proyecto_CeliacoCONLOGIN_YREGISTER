using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Proyecto_Celiaco.card_recetas
{
    public class Receta
    {
        [PrimaryKey, AutoIncrement]
        public int receta_id { get; set; }
        [MaxLength(80)]
        public string nombre { get; set; }
        public int dif_id { get; set; }
        public int tiempo { get; set; }
        public string url { get; set; }

        public int cant_total_ing { get; set; }
        public int cant_user { get; set; }
        public string mensaje { get; set; }
        public Color color_dif { get; set; }
    }
}
