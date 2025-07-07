using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavarreteJExamenP3.Modelos
{
    class Proyecto
    {

        public int Id { get; set; }
        public string NombreProyecto { get; set; }
        public string Descripcion { get; set; }
        public int Progreso { get; set; }
        public int DuracionDias { get; set; }

    }
}
