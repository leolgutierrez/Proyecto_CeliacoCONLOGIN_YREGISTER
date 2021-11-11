using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLitePCL;
using SQLite;
using Proyecto_Celiaco.card;
using System.IO;
//exporto una fuente a
[assembly: ExportFont("Sketch_3D.otf", Alias = "3d")]

namespace Proyecto_Celiaco
{
    public partial class App : Application
    {
        //instancio la bdd que va a ocupar el proyect
        static Sqlitehelper db;
        public App()
        {
            InitializeComponent();

            MainPage = new Paginainicial();
        }

        //si no tenemos base la genera 
        public static Sqlitehelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new Sqlitehelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proyectox.db3"));

                }
                return db;
            }

        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
