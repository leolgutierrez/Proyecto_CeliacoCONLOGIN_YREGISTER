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
using Proyecto_Celiaco.card;

namespace Proyecto_Celiaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public  partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            //para que se instancie la tabla,le creamos un catch 

            try
            {
                //ACA SACO LA DIRECC DE LA BDD ,ES MUCHO MEJOR USAR EL USING PARA QUE LA BASE NO SE BLOQUEE
                using (SqliteConnection db =
                   new SqliteConnection($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3")}"))
                {

                    db.Open();//abro la canilla
                    string comando = "select nombre_usuario from usuario where nombre_usuario='" + txtboxusuario.Text + "' and contraseña='" + txtboxcontraseña.Text + "'"; //un ejemplo de select
                    SqliteCommand cum = new SqliteCommand(comando, db);


                    SqliteDataReader leedor = cum.ExecuteReader(); //abro un reader para que sea mas facil el manejo de datos
                    leedor.Read();
                }
            }

            catch
            {
                //ACA CREAMOS AL USUARIO TEMPORAL
                usuario temp = new usuario()
                {
                    email = "a",
                    nombre_usuario = "b",
                    contraseña = "c",
              

                };
                App.SQLiteDB.SaveusuarioAsync(temp);

                //usuario temp creado

                //SOLO EN LA PRIMERA VEZ QUE SE LOGEE LA APP
                usuario pep = new usuario()
                {
                    email = "leo@gmail.com",
                    nombre_usuario = "leolol",
                    contraseña = "123456"   
                };

                App.SQLiteDB.SaveusuarioAsync(pep);
                

               
            }

            




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
                string actualizar = "update usuario set nombre_usuario='" + txtboxusuario.Text+"' where id_usuario = 1";
  
                SqliteCommand cum = new SqliteCommand(comando, db);
                SqliteCommand dip = new SqliteCommand(actualizar, db);
                

                SqliteDataReader leedor = cum.ExecuteReader(); //abro un reader para que sea mas facil el manejo de datos
                if (leedor.Read())
                {
                    
                    SqliteDataReader lector = dip.ExecuteReader(); //deberia hacer el update
                    
                    lector.Read();
                    
                   
                    
                   
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