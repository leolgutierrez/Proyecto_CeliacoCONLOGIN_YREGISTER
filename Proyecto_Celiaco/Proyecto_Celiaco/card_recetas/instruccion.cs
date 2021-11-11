using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    class instruccion
    {
        [PrimaryKey, AutoIncrement]
        public int inst_id { get; set; }
        [MaxLength(400)]
        public string descripcion { get; set; }
        public int receta_id { get; set; }
        public string url { get; set; }
    }
}
