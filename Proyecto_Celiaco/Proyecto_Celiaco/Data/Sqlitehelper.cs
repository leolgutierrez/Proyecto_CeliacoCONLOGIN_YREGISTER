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
            db.CreateTableAsync<Direcciones>().Wait();
            db.CreateTableAsync<usuario>().Wait();
        }
        //insercion
        public Task <int> SaveDireccion(Direcciones dir)
        {
            if (dir.dir_id == 0)
            {
                return db.InsertAsync(dir);
            }
            else
            {
                return null;
            }
        }

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





        //recupera todas las direcciones
        public Task<List<Direcciones>> GetDirAsync()
        {
            return db.Table<Direcciones>().ToListAsync();
        }
        //recuperar dir por id
        public Task<Direcciones> GetDirbyidAsync(int dirid)
        {
            return db.Table<Direcciones>().Where(a => a.dir_id == dirid).FirstOrDefaultAsync();
        }


        //recuperar usuario
        public Task<List<usuario>> GetusuariosAsync()
        {
            return db.Table<usuario>().ToListAsync();
        }

    }
}
