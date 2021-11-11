using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;

namespace Proyecto_Celiaco.card
{
    public class Direcciones
    {
        [PrimaryKey,AutoIncrement]
        public int dir_id { get; set; }
        [MaxLength(80)]
        public string nombre { get; set; }
        [MaxLength(80)]
        public string direccion { get; set; }
        [MaxLength(40)]
        public string tipo_local { get; set; }
        public Color color_local { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
    }
}
