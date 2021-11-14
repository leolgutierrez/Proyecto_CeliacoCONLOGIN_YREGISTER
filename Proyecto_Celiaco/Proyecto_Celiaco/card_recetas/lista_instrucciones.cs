using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Proyecto_Celiaco.card_recetas
{
    public class lista_instrucciones
    {
        public ObservableCollection<instruccion> lstrec { get; set; }

        public lista_instrucciones()
        {
           ObservableCollection<instruccion> lstrec = new ObservableCollection<instruccion>();
            GenerarTarjetas();
        }
        public void GenerarTarjetas()
        {
            //Aqui la carga de datos en una lista de los instrucciones de una receta x
            //biscochitos salados
            lstrec.Add(new instruccion() {inst_id=1,receta_id=1,descripcion= "1. Con un recipiente poner la crema de leche" });
            lstrec.Add(new instruccion() { inst_id = 2, receta_id = 1, descripcion = "2. Lavar el pote de crema y medir 2 potes de premezcla, salando a gusto" });
            lstrec.Add(new instruccion() { inst_id = 3, receta_id = 1, descripcion = "3. Amasar hasta formar una masa que nose pegue en los dedos" });
            lstrec.Add(new instruccion() { inst_id = 4, receta_id = 1, descripcion = "4. Saborizar a gusto con oregano o queso u / u otro saborizante a gusto" });
            lstrec.Add(new instruccion() { inst_id = 5, receta_id = 1, descripcion = "5. Tomar porciones de masa y estirar con rodillo y cortar los bizcochitos con cortantes" });
            lstrec.Add(new instruccion() { inst_id = 6, receta_id = 1, descripcion = "6. Cocción: horno precalentado máximo(180°C) hasta que se doren." });

        }


    }
}

