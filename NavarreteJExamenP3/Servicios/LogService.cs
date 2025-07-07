using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavarreteJExamenP3.Servicios
{
    class LogService
    {
        private readonly string logFilePath = Path.Combine(FileSystem.AppDataDirectory, "logs_Navarrete.txt");
        public static LogService Instance { get; } = new LogService();
        public async Task AppendLog(string nombreProyecto)
        {
            
        }
    }
}
