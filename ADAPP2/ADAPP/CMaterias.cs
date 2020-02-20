using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CMaterias
    {
        public int Id_Materia { get; set; }
        public string Nombre_Materia { get; set; }
        public int Horas_Totales { get; set; }
        public int Id_Ciclo{ get; set; }
        
        public string Id_Usuario { get; set; }

        public CMaterias(int Id_Materia, string Nombre_Materia,int Horas_Totales,int Id_Ciclo, string Id_Usuario)
        {
            this.Id_Materia = Id_Materia;
            this.Nombre_Materia = Nombre_Materia;
            this.Horas_Totales = Horas_Totales;
            this.Id_Ciclo = Id_Ciclo;
            this.Id_Usuario = Id_Usuario;
        }
        public CMaterias() { }


    }
}
