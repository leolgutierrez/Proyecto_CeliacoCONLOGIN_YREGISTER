 using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class lista_recetas
    {
        public ObservableCollection<Receta> lstrec { get; set; }
        public lista_recetas()
        {
            lstrec = new ObservableCollection<Receta>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui iria el la carga de datos de la lista de recetas que se mostraran para seleccionar
            lstrec.Add(new Receta { receta_id = 1 ,nombre= "Bizcochitos Salados",dif_id=1,tiempo=30,url= "http://recetasargentinas.net/wp-content/uploads/2017/11/bizcochitos-min.jpg" });
            lstrec.Add(new Receta { receta_id = 2, nombre = "Pancitos sin harina", dif_id = 1, tiempo = 20, url = "https://modoglutenfree.com/wp-content/uploads/2019/02/pan-sin-gluten-006-1.jpg" });
            lstrec.Add(new Receta { receta_id = 3, nombre = "Pan Nube", dif_id = 1, tiempo = 25, url = "https://i.ytimg.com/vi/1vnh77NpxEE/maxresdefault.jpg" });
            lstrec.Add(new Receta { receta_id = 4, nombre = "Torta Esponjosa", dif_id = 2, tiempo = 45, url = "https://t1.rg.ltmcdn.com/es/images/0/1/4/bizcocho_suave_y_esponjoso_de_vainilla_58410_600_square.jpg" });
            lstrec.Add(new Receta { receta_id = 5, nombre = "Zapallitos rellenos con salsa blanca", dif_id = 3, tiempo = 90, url = "http://2.bp.blogspot.com/-plUJZYTcVBw/T2vou6j6wAI/AAAAAAAAElk/nljjWRw0Vgs/s1600/zapallitos+_rellenosBC.jpg" });

        }

    }
}
