using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Proyecto_Celiaco.card;
using System.Threading.Tasks;

namespace Proyecto_Celiaco.card
{
    public class Sqlitehelper
    {
        SQLiteAsyncConnection db;
        public Sqlitehelper(string dbruta)
        {
            db = new SQLiteAsyncConnection(dbruta);
            
            //db.CreateTableAsync<Direcciones>().Wait();
            
            db.CreateTableAsync<usuario>().Wait();
            db.CreateTableAsync<RecetaFav>().Wait();
            //db.CreateTableAsync<usuariotemp>().Wait();
        }
        //insercion
        //public Task <int> SaveDireccion(Direcciones dir)
        //{
        //    if (dir.dir_id == 0)
        //    {
        //        return db.InsertAsync(dir);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        // insertar un usuario
        public Task<int> SaveusuarioAsync(usuario usuario)
        {
            if (usuario.id_usuario == 0)
            {
                return db.InsertAsync(usuario);
                
            }

            else
            {
                return null;
            }
        }

        public Task<int> SaveRecetaFav(RecetaFav receta)
        {
            if (receta.recetafav_id == 0)
            {
                return db.InsertAsync(receta);

            }

            else
            {
                return null;
            }
        }



        //para ingresar al usuario temporal , solo un uso despues modificamos xd
        /*public Task<int> SaveusuariotempAsync(usuariotemp usuariio)
        {
            if (usuariio.id_usuarioo == 0)
            {
                return db.InsertAsync(usuariio);
            }
            else
            {
                return null;
            }
        }*/




        //recupera todas las direcciones
        //public Task<List<Direcciones>> GetDirAsync()
        //{
        //    return db.Table<Direcciones>().ToListAsync();
        //}
        ////recuperar dir por id
        //public Task<Direcciones> GetDirbyidAsync(int dirid)
        //{
        //    return db.Table<Direcciones>().Where(a => a.dir_id == dirid).FirstOrDefaultAsync();
        //}


        //recuperar usuario
        public Task<List<usuario>> GetusuariosAsync()
        {
            return db.Table<usuario>().ToListAsync();
        }

    }
}
