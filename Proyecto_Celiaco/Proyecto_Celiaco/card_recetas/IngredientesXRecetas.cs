using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class IngredientesXRecetas
    {
        public int ing_Id { get; set; }
        public int receta_id { get; set; }
        public double cant { get; set; }
        public string unidad { get; set; }
    }
}
