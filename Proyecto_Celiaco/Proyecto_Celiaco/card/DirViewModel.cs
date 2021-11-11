using card;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto_Celiaco.card
{
    public class DirViewModel
    {
        public ObservableCollection<Direcciones> lstDir { get; set; }
        public DirViewModel()
        {
            lstDir = new ObservableCollection<Direcciones>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //celicias
            var direccionn = new Direcciones()
            {
                nombre = "Celicias",
                direccion = "Pasaje Villagra 447",
                color_local = StyleKit.direc_color.panaderia,
                tipo_local = "Panaderias",
                latitud = -24.7940064,
                longitud = -65.4330778

            };
            lstDir.Add(direccionn);
            //Bendita Gula
            lstDir.Add(new Direcciones(){nombre = "BENDITA GULA", direccion = "Gral. Savio 1005", color_local = StyleKit.direc_color.restaurante,tipo_local = "Restaurantes",latitud= -24.7741448,longitud= -65.4423567 });
            //rocco
            lstDir.Add(new Direcciones() { nombre = "Rocco fit", direccion = "Leguizamón 402", color_local = StyleKit.direc_color.bar, tipo_local = "Bares", latitud = -24.7840087, longitud = -65.407873 });
            //Rincon Saludable - Tienda Naturista
            lstDir.Add(new Direcciones() { nombre = "Rincon Saludable - Tienda Naturista", direccion = "Juan M Leguizamon 752", color_local = StyleKit.direc_color.tienda, tipo_local = "Tiendas", latitud = -24.783488, longitud =-65.4123266 });
            //Trattoria Mamma Mia
            lstDir.Add(new Direcciones() { nombre = "Trattoria Mamma Mia", direccion = "Pje. Zorrilla 1", color_local = StyleKit.direc_color.restaurante, tipo_local = "Restaurantes", latitud = -24.7883298, longitud =-65.4024857 });
            //Que Mamma
            lstDir.Add(new Direcciones() { nombre = "Que Mamma", direccion = "Av. del Bicentenario de la Batalla de Salta 95", color_local = StyleKit.direc_color.restaurante, tipo_local = "Restaurantes", latitud = -24.7893602, longitud =-65.4024137 });
            //Panetteria sin tacc
            lstDir.Add(new Direcciones() { nombre = "Panetteria sin tacc", direccion = " Marcelo T. de Alvear 455", color_local = StyleKit.direc_color.panaderia, tipo_local = "Panaderias", latitud = -24.7836722, longitud = -65.4189281 });

        }
    }
}
