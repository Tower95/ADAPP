using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CRelacionados
    {
        public string Nombre_Materia { get; set; }
        public string Nombre_Grupo { get; set; }

        public CRelacionados(string Nombre_Materia, string Nombre_Grupo)
        {
            this.Nombre_Grupo = Nombre_Grupo;
            this.Nombre_Materia = Nombre_Materia;
        }
    }
}
