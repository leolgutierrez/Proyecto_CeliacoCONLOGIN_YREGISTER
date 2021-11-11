using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class Dificultad
    {
        [PrimaryKey, AutoIncrement]
        public int dif_id { get; set; }
        [MaxLength(80)]
        //dificultad,mediano o facil
        public string descripcion { get; set; }
    }
}
