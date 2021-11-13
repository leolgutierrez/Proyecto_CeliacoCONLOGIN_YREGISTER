using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto_Celiaco.card
{
    public class usuariotemp
    {
        [PrimaryKey]
        public int id_usuarioo { get; set; }

        [MaxLength(50)]
        public string email { get; set; }

        [MaxLength(50)]
        public string contraseña { get; set; }

        [MaxLength(50)]
        public string nombre_usuario { get; set; }

    }
}
