using Proyecto_Celiaco.card_recetas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrousel_Instrucciones : ContentPage
    {
        //public class instInformation

        //{

        //    public string _textinst { get; set; }

        //}
        int rec_id = 0;
        string url = "";
        public ObservableCollection<instruccion> instrucciones { get; set; }
        public class text_desc

        {

            public int inst_id { get; set; }
            
            public string descripcion { get; set; }
            public int receta_id { get; set; }
            public string url { get; set; }

        }

        private ObservableCollection<text_desc> descCollection;

        public ObservableCollection<text_desc> DescCollection

        {

            get { return descCollection; }

            set

            {

                descCollection = value;

                OnPropertyChanged();



            }

        }
        public ObservableCollection<text_desc> lista

        {

            get { return descCollection; }

            set

            {

                descCollection = value;

                OnPropertyChanged();



            }

        }
        public Carrousel_Instrucciones(int id,string titulo,string aux_url)
        {
            InitializeComponent();
            rec_id = id;
            lbl_titulo.Text = titulo;
            url = aux_url;
            //ImageCollection = new ObservableCollection<ImageInformation> {

            //    new ImageInformation{_Image="image1.png"},

            //    new ImageInformation{_Image="image2.png"},

            //    new ImageInformation{_Image="image3.png"}

            //  };
            DescCollection = new ObservableCollection<text_desc>();
            lista = new ObservableCollection<text_desc>();
            
            //cargartabla2();
            //cargarlista(rec_id);
            cargartabla(rec_id);
            BindingContext = this;

            //cargarlista(rec_id);
            //DescCollection.Add(new text_desc { _Image="1. pegate un tiro"});
            //DescCollection.Add(new text_desc { _Image = "1. pegate un tiro1" });
            //DescCollection.Add(new text_desc { _Image = "1. pegate un tiro2" });
            //DescCollection.Add(new text_desc { _Image = "1. pegate un tiro3" });
            //DescCollection.Add(new text_desc { _Image = "1. pegate un tiro4" });


        }

        private void cargarlista(int id)
        {
            int i = 0;
            while (i < descCollection.Count)
            {
                if (descCollection[i].receta_id == id)
                {
                    lista.Add(descCollection[i]);
                }
                i++;
            }
        }

        public void cargartabla(int id)
        {
            switch (id)
            {
                case 1:
                    //biscochitos salados

                    DescCollection.Add(new text_desc { inst_id = 1, receta_id = 1, descripcion = "1. Con un recipiente poner la crema de leche" });
                    DescCollection.Add(new text_desc { inst_id = 2, receta_id = 1, descripcion = "2. Lavar el pote de crema y medir 2 potes de premezcla, salando a gusto" });
                    DescCollection.Add(new text_desc { inst_id = 3, receta_id = 1, descripcion = "3. Amasar hasta formar una masa que nose pegue en los dedos" });
                    DescCollection.Add(new text_desc { inst_id = 4, receta_id = 1, descripcion = "4. Saborizar a gusto con oregano, queso u  otro saborizante a gusto" });
                    DescCollection.Add(new text_desc { inst_id = 5, receta_id = 1, descripcion = "5. Tomar porciones de masa y estirar con rodillo y cortar los bizcochitos con cortantes" });
                    DescCollection.Add(new text_desc { inst_id = 6, receta_id = 1, descripcion = "6. Cocción: horno precalentado máximo(180°C) hasta que se doren." });
                    break;
                case 2:
                    //pancitos sin harina

                    DescCollection.Add(new text_desc { inst_id = 1, receta_id = 2, descripcion = "1.	En un bol batir ligeramente los huevos. Despues, agregar la leche con el polvo de hornear. Mezclar todo muy bien hasta que este integrado" });
                    DescCollection.Add(new text_desc { inst_id = 2, receta_id = 2, descripcion = "2.	En una asadera aceitada disponemos 6 cucharadas de la mezcla. Y con la parte de atrás de una cuchara mojada aplastamos y damos forma redondeada." });
                    DescCollection.Add(new text_desc { inst_id = 3, receta_id = 2, descripcion = "3.	Coccion: Horno precalculado (180°c)  moderado por 10 minutos aproximadamente." });
                    break;
                case 3:
                    //panes nubes
                    DescCollection.Add(new text_desc { inst_id = 1, receta_id = 3, descripcion = "1.	Tomar el huevo, romperlo y mezclarlo con el polvo de hornear en un bol" });
                    DescCollection.Add(new text_desc { inst_id = 2, receta_id = 3, descripcion = "2.	Agregar la leche en polvo y seguir mezclando hasta que quede homogeneo" });
                    DescCollection.Add(new text_desc { inst_id = 3, receta_id = 3, descripcion = "3.	Cuando tengas la mezcla lista prepara una placa de silicona con papel manteca." });
                    DescCollection.Add(new text_desc { inst_id = 3, receta_id = 3, descripcion = "4.	Cocción: horno precalentado (180 °c). Cocinarlos a horno moderado por 15 minutos aproximadamente." });

                    break;
                case 4:
                    //Torta Esponjosa
                    DescCollection.Add(new text_desc { inst_id = 1, receta_id = 4, descripcion = "1.	Precalentar horno moderado (180 °C)" });
                    DescCollection.Add(new text_desc { inst_id = 2, receta_id = 4, descripcion = "2.	En un bol mezclar ingredientes secos con ingredientes húmedos y batir hasta obtener una masa suave." });
                    DescCollection.Add(new text_desc { inst_id = 3, receta_id = 4, descripcion = "3.	Enmantecar un molde circular de 20 cm de diámetro y verter en el la mezcla." });
                    DescCollection.Add(new text_desc { inst_id = 3, receta_id = 4, descripcion = "4.	Coccion: horno moderado (180 °c) por 30 minutos aproximadamente." });

                    break;
                case 5:
                    //Zapallito
                    DescCollection.Add(new text_desc { inst_id = 1, receta_id = 5, descripcion = "1.	Hervir los zapallos con semillas cortados por la mitad. Una vez cocidos, colocar las mitades en una asadera con aceite, y sacarles las semillas" });
                    DescCollection.Add(new text_desc { inst_id = 2, receta_id = 5, descripcion = "2.	Rallar zanahoria, picar cebolla y pimiento y dorar en aceite en una hora estos últimos 2." });
                    DescCollection.Add(new text_desc { inst_id = 3, receta_id = 5, descripcion = "3.	 Cocinar la carne con la zanahoria y el tomate picado. Condimentar con sal y agregar un poco de agua.En paralelo,mezclar la manteca la maizena y la leche y cocinar a fuego moderado,cuando comienze a espesarse,bajar el fuego a mínimo y cocinar.En caso de que tenga una consistencia un poco rigida,Agregar un poco de mas de leche." });
                    DescCollection.Add(new text_desc { inst_id = 4, receta_id = 5, descripcion = "4.	Rellenar los zapallitos con la carne y cubrirlos con salsa blanca." });


                    break;

            }
        }
            public void cargartabla2()
            {

                        //biscochitos salados

                        DescCollection.Add(new text_desc { inst_id = 1, receta_id = 1, descripcion = "1. Con un recipiente poner la crema de leche" });
                        DescCollection.Add(new text_desc { inst_id = 2, receta_id = 1, descripcion = "2. Lavar el pote de crema y medir 2 potes de premezcla, salando a gusto" });
                        DescCollection.Add(new text_desc { inst_id = 3, receta_id = 1, descripcion = "3. Amasar hasta formar una masa que nose pegue en los dedos" });
                        DescCollection.Add(new text_desc { inst_id = 4, receta_id = 1, descripcion = "4. Saborizar a gusto con oregano, queso u  otro saborizante a gusto" });
                        DescCollection.Add(new text_desc { inst_id = 5, receta_id = 1, descripcion = "5. Tomar porciones de masa y estirar con rodillo y cortar los bizcochitos con cortantes" });
                        DescCollection.Add(new text_desc { inst_id = 6, receta_id = 1, descripcion = "6. Cocción: horno precalentado máximo(180°C) hasta que se doren." });

                        //pancitos sin harina

                        DescCollection.Add(new text_desc { inst_id = 1, receta_id = 2, descripcion = "1.	En un bol batir ligeramente los huevos. Despues, agregar la leche con el polvo de hornear. Mezclar todo muy bien hasta que este integrado" });
                        DescCollection.Add(new text_desc { inst_id = 2, receta_id = 2, descripcion = "2.	En una asadera aceitada disponemos 6 cucharadas de la mezcla. Y con la parte de atrás de una cuchara mojada aplastamos y damos forma redondeada." });
                        DescCollection.Add(new text_desc { inst_id = 3, receta_id = 2, descripcion = "3.	Coccion: Horno precalculado (180°c)  moderado por 10 minutos aproximadamente." });

                        //panes nubes
                        DescCollection.Add(new text_desc { inst_id = 1, receta_id = 3, descripcion = "1.	Tomar el huevo, romperlo y mezclarlo con el polvo de hornear en un bol" });
                        DescCollection.Add(new text_desc { inst_id = 2, receta_id = 3, descripcion = "2.	Agregar la leche en polvo y seguir mezclando hasta que quede homogeneo" });
                        DescCollection.Add(new text_desc { inst_id = 3, receta_id = 3, descripcion = "3.	Cuando tengas la mezcla lista prepara una placa de silicona con papel manteca." });
                        DescCollection.Add(new text_desc { inst_id = 3, receta_id = 3, descripcion = "4.	Cocción: horno precalentado (180 °c). Cocinarlos a horno moderado por 15 minutos aproximadamente." });

                        //Torta Esponjosa
                        DescCollection.Add(new text_desc { inst_id = 1, receta_id = 4, descripcion = "1.	Precalentar horno moderado (180 °C)" });
                        DescCollection.Add(new text_desc { inst_id = 2, receta_id = 4, descripcion = "2.	En un bol mezclar ingredientes secos con ingredientes húmedos y batir hasta obtener una masa suave." });
                        DescCollection.Add(new text_desc { inst_id = 3, receta_id = 4, descripcion = "3.	Enmantecar un molde circular de 20 cm de diámetro y verter en el la mezcla." });
                        DescCollection.Add(new text_desc { inst_id = 3, receta_id = 4, descripcion = "4.	Coccion: horno moderado (180 °c) por 30 minutos aproximadamente." });


                        //Zapallito
                        DescCollection.Add(new text_desc { inst_id = 1, receta_id = 5, descripcion = "1.	Hervir los zapallos con semillas cortados por la mitad. Una vez cocidos, colocar las mitades en una asadera con aceite, y sacarles las semillas" });
                        DescCollection.Add(new text_desc { inst_id = 2, receta_id = 5, descripcion = "2.	Rallar zanahoria, picar cebolla y pimiento y dorar en aceite en una hora estos últimos 2. Cocinar la carne con la zanahoria y el tomate picado. Condimentar con sal y agregar un poco de agua.En paralelo,mezclar la manteca la maizena y la leche y cocinar a fuego moderado,cuando comienze a espesarse,bajar el fuego a mínimo y cocinar.En caso de que tenga una consistencia un poco rigida,Agregar un poco de mas de leche." });
                        DescCollection.Add(new text_desc { inst_id = 3, receta_id = 5, descripcion = "3.	Rellenar los zapallitos con la carne y cubrirlos con salsa blanca." });


                }
                //Aqui la carga de datos en una lista de los instrucciones de una receta x
            }

    }
