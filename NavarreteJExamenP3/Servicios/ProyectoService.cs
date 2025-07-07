using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavarreteJExamenP3.Servicios
{
    class ProyectoService
    {
        private static SQLiteAsyncConnection _database;
        public static ProyectoService Instance { get; } = new ProyectoService();
        private ProyectoService() { }
        public async Task Init()
        {
            if (_database != null)
                return;
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "proyectos.db3");
            _database = new SQLiteAsyncConnection(dbPath);
            await _database.CreateTableAsync<Proyecto>();
        }
        public Task<List<Proyecto>> ObtenerProyectos() =>
            _database.Table<Proyecto>().ToListAsync();
        public Task<int> AgregarProyecto(Proyecto p) => _database.InsertAsync(p);

    }
}
