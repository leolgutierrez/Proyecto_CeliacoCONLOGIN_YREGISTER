using card;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class list_dif
    {
        public ObservableCollection<Dificultad> lstinst { get; set; }
        public list_dif()
        {
            lstinst = new ObservableCollection<Dificultad>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui la carga de datos en una lista de los instrucciones de una receta x
            lstinst.Add(new Dificultad() { dif_id = 1, tipo = "Fácil", color_dif = StyleKit.receta_color.facil, descripcion = "Receta sencillas y rapidas de nomas de 30 minutos!" });
            lstinst.Add(new Dificultad() { dif_id = 2, tipo = "Intermedio", color_dif = StyleKit.receta_color.mediano, descripcion = "Recetas de 1 a 2 horas para disfrutar y compartir con familia y amigos!" });
            lstinst.Add(new Dificultad() { dif_id = 3, tipo = "Dificil", color_dif = StyleKit.receta_color.dificil, descripcion = "Verdaderos desafios de 2 horas o mas con exquisitos resultados!" });

        }

    }
}
