using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class lista_ing_Recetas
    {
        public ObservableCollection<IngredientesXRecetas> lstrec { get; set; }
        public lista_ing_Recetas()
        {
            lstrec = new ObservableCollection<IngredientesXRecetas>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui iria el la carga de datos de la lista de ingredientes de cada recetas que se mostraran para seleccionar
            //Bizcochitos Salados
            lstrec.Add(new IngredientesXRecetas(){ing_Id = 15,cant = 1,unidad = "Unidad/es",receta_id = 1});
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 4, cant = 2, unidad = "Tazas", receta_id = 1 });
            //Pancitos sin harina
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 2, cant = 180, unidad = "Gramos", receta_id = 2 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 1, cant = 3, unidad = "Unidad/es", receta_id = 2 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 3, cant = 3, unidad = "Cucharadas", receta_id = 2 });
            //panes nubes
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 2, cant = 12, unidad = "Cucharadas", receta_id = 3 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 1, cant = 2, unidad = "Unidad/es", receta_id = 3});
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 3, cant = 2, unidad = "Cucharadas", receta_id = 3 });
            //torta
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 4, cant = 200, unidad = "Gramos", receta_id = 4 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 16, cant = 200, unidad = "Gramos", receta_id = 4 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 3, cant = 1, unidad = "Cucharadas", receta_id = 4 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 5, cant = 0.25, unidad = "Cucharadas", receta_id = 4 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 1, cant = 3, unidad = "Unidad/es", receta_id = 4 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 6, cant = 200, unidad = "Gramos", receta_id = 4 });
            //Zapallitos
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 7, cant = 6, unidad = "Unidad/es", receta_id = 5 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 8, cant = 300, unidad = "Gramos", receta_id = 5 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 9, cant = 1, unidad = "Unidad/es", receta_id = 5 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 10, cant = 0.5, unidad = "Unidad/es", receta_id = 5 }); 
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 11, cant = 1, unidad = "Unidad/es", receta_id = 5 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 12, cant = 1, unidad = "Unidad/es", receta_id = 5 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 6, cant = 1, unidad = "Cucharadas", receta_id = 5 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 13, cant = 2, unidad = "Cucharadas", receta_id = 5 });
            lstrec.Add(new IngredientesXRecetas() { ing_Id = 14, cant = 1, unidad = "Tazas", receta_id = 5 });


        }
    }
}
