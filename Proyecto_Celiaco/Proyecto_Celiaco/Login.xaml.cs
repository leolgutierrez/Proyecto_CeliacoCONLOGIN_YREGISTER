using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using SQLitePCL;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Net;
using System.Net.Mail;


namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnregistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Registro());
        }

        private async void botonlogear_Clicked(object sender, EventArgs e)
        {
            
            //ACA SACO LA DIRECC DE LA BDD ,ES MUCHO MEJOR USAR EL USING PARA QUE LA BASE NO SE BLOQUEE
            using (SqliteConnection db =
               new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
            {

                db.Open();//abro la canilla
                string comando = "select nombre_usuario from usuario where nombre_usuario='"+txtboxusuario.Text+"' and contraseña='"+txtboxcontraseña.Text+"'"; //un ejemplo de select
                SqliteCommand cum = new SqliteCommand(comando, db);


                SqliteDataReader leedor = cum.ExecuteReader(); //abro un reader para que sea mas facil el manejo de datos
                if (leedor.Read())
                {
                    await Navigation.PushModalAsync(new chef_menu());
                    ; //el primer resultado de una tabla imaginaria
                }

                else
                {
                    await DisplayAlert("ERROR", "Usuario o contraseña incorrectos", "uwu") ;

                }

            }
            


        }

        







    }
}