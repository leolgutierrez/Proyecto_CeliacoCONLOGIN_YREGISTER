using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Proyecto_Celiaco.card


{
    public class RecetaFav
    {
        [PrimaryKey, AutoIncrement]
        public int recetafav_id { get; set; }
        
        public int id_usuario { get; set; }
        
        public int id_receta { get; set; }
        

        
        
    }
}
