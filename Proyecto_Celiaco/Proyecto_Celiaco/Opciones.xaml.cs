using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using SQLitePCL;
using Proyecto_Celiaco.card;
using System.IO;
using Microsoft.Data.Sqlite;


namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opciones : ContentPage
    {
        public Opciones()
        {
            InitializeComponent();

            string a = session_temp();
            if (a != "")//detecta que hay un logeo
            {
                labelBienbenida.IsVisible = false;
                labelnomusuario.IsVisible = true;
                labelnomusuario.Text = "EYYY BIENVENIDO" + " " + session_temp();
                btniniciarsesion.IsVisible = false;
                btncerrarsession.IsVisible = true;
                labelpruebe.IsVisible = false;
            }

            else
            {
                //no hay un logeo
                labelnomusuario.IsVisible = false;
                btncerrarsession.IsVisible = false;
                labelBienbenida.IsVisible = true;

            }


        }

        private async void btniniciarsesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }

        public string session_temp()
        {
            string usuario;
            //ACA SACO LA DIRECC DE LA BDD 
            using (SqliteConnection db =
                new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {
                db.Open();//abro la canilla
                string comando = "select nombre_usuario from usuario where id_usuario=1"; //BUSCO AL USUARIO SESSION
                SqliteCommand cum = new SqliteCommand(comando, db);


                SqliteDataReader leedor = cum.ExecuteReader(); //abro un reader para que sea mas facil el manejo de datos
                                                               // try
                leedor.Read();                                            //{
                string result = leedor.GetValue(0).ToString();
                if (result != "b")
                {
                    usuario = result;
                    btniniciarsesion.Text = "ELPEPE";  //ENTRO AQUII

                    ; //el primer resultado de una tabla imaginaria
                }

                else
                {
                    usuario = "";
                }
            }

            //}


            

            return usuario;


        }


        

            
        


        private async void btncerrarsession_Clicked(object sender, EventArgs e)
        {
            labelpruebe.IsVisible = true;
            btncerrarsession.IsVisible = false;
            labelnomusuario.Text = "EYYY BIENVENIDO";
            labelnomusuario.IsVisible = false;


            //el update


            using (SqliteConnection db =
                new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {
                db.Open();//abro la canilla
                string comando = "update usuario set nombre_usuario='" + "b"+ "' where id_usuario = 1"; //BUSCO AL USUARIO SESSION
                SqliteCommand cum = new SqliteCommand(comando, db);


                SqliteDataReader leedor = cum.ExecuteReader(); //abro un reader para que sea mas facil el manejo de datos

                leedor.Read();

                await Navigation.PushModalAsync(new chef_menu());



            }


        }

        private void btnregistro_Clicked(object sender, EventArgs e)
        {

        }
    }
}