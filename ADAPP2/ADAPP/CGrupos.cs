using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CGrupos
    {
        public int Id_Grupo { get; set; }
        public string Nombre_Grupo { get; set; }
        public int Id_Ciclo { get; set; }

        public CGrupos(int Id_Grupo, string Nombre_Grupo, int Id_Ciclo)
        {
            this.Id_Grupo = Id_Grupo;
            this.Nombre_Grupo = Nombre_Grupo;
            this.Id_Ciclo = Id_Ciclo;
        }
    }
}
