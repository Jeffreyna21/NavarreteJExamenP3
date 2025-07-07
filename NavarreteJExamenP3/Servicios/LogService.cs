using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavarreteJExamenP3.Servicios
{
    class LogService
    {
        private readonly string logFilePath = Path.Combine(FileSystem.AppDataDirectory, "Logs_Navarrete.txt");
        public static LogService Instance { get; } = new LogService();

        public async Task AppendLog(string nombreProyecto)
        {
            string log = $"Se incluyó el registro [{nombreProyecto}] el {DateTime.Now:dd/MM/yyyy HH:mm}\n";
            await File.AppendAllTextAsync(logFilePath, log);
        }

        public async Task<List<string>> LeerLogs()
        {
            if (!File.Exists(logFilePath))
                return new List<string>();

            var lineas = await File.ReadAllLinesAsync(logFilePath);
            return lineas.ToList();
        }
    }
}
