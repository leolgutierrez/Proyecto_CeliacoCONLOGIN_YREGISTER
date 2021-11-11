using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Proyecto_Celiaco.card
{
    public class usuario
    {
        [PrimaryKey, AutoIncrement]
        public int id_usuario { get; set; }

        [MaxLength(50)]
        public string email { get; set; }

        [MaxLength(50)]
        public string contraseña { get; set; }

        [MaxLength(50)]
        public string nombre_usuario { get; set; }

    }
}
