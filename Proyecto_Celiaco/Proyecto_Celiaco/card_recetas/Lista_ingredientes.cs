using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class Lista_ingredientes
    {
        public ObservableCollection<ingrediente> lstrec { get; set; }
        public Lista_ingredientes()
        {
            lstrec = new ObservableCollection<ingrediente>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui iria el la carga de datos de la lista de ingredientes que se mostraran para seleccionar
            lstrec.Add(new ingrediente { ing_Id = 1 ,nombre="Huevos",url= "https://static1.abc.es/media/bienestar/2020/10/11/huevos-colores-kZ1B--620x349@abc.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 2, nombre = "Leche en polvo", url = "https://www.lacteoslatam.com/images/stories/2017/05_Mayo/leche-en-polvo-poceso.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 3, nombre = "Polvo de hornear", url = "https://layuntamayorista.com/wp-content/uploads/2020/05/POLVO-DE-HORNEAR-FLOR-CALSA-x-2-kg.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 4, nombre = "Premezcla sin gluten", url = "https://www.soyceliaconoextraterrestre.com/wp-content/uploads/2020/01/premezcla.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 5, nombre = "Goma Xántica", url = "https://glutendence.com/wp-content/uploads/elementor/thumbs/goma-xantana-scaled-p1vz9nilm4vk0qet8px8ppp1ferrw7ujgk9m99z9ds.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 6, nombre = "Manteca", url = "https://www.cucinare.tv/wp-content/uploads/2020/01/Manteca-1.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 7, nombre = "Zapallitos Verdes", url = "https://www.nutricionyentrenamiento.fit/images/alimento/274.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 8, nombre = "Carne molida", url = "https://cdn.recetas360.com/wp-content/uploads/2021/03/como-hacer-carne-molida.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 9, nombre = "Cebolla", url = "https://www.salud.mapfre.es/media/2016/07/cebolla-fibra-antioxidantes-3-1280x720.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 10, nombre = "Pimiento Colorado", url = "https://http2.mlstatic.com/D_NQ_NP_789335-MLA43107606030_082020-O.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 11, nombre = "Zanahoria", url = "https://www.conasi.eu/blog/wp-content/uploads/2018/07/zanahorias-y-tomar-el-sol.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 12, nombre = "Tomate", url = "https://www.lovemysalad.com/sites/default/files/styles/image_530x397/public/tomates_-_vladimir_morozov.jpg?itok=XMg8FUqr" });
            lstrec.Add(new ingrediente { ing_Id = 13, nombre = "Fecula de Maiz", url = "https://cdn2.cocinadelirante.com/sites/default/files/images/2017/10/diferenciaentrealmidondemaizymaicena.jpg" });
            lstrec.Add(new ingrediente { ing_Id = 14, nombre = "Leche (Liquida)", url = "https://imagenes.elpais.com/resizer/5nI4wXyGN_4jvSSsa03TTuYdOfQ=/980x735/cloudfront-eu-central-1.images.arcpublishing.com/prisa/4JW7BFJRRQVJDRT55GABP2P6HU.jpg" });


        }
    }
}
