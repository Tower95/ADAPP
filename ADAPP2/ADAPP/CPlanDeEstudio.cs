using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CPlanDeEstudio
    {
        public int Id_PE { get; set; }
        public int Examen { get; set; }
        public int Tareas { get; set; }
        public int Practicas { get; set; }
        public int Asistencia { get; set; }
        public int Extra { get; set; }
        public int Unidad { get; set; }
        public int Id_Materia { get; set; }

        public CPlanDeEstudio(int Id_PE, int Examen,int Tareas, int Practicas, int Asistencia, int Extra, int Unidad, int Id_Materia)
        {
            this.Id_PE = Id_PE;
            this.Examen = Examen;
            this.Tareas = Tareas;
            this.Practicas = Practicas;
            this.Asistencia = Asistencia;
            this.Extra = Extra;
            this.Unidad = Unidad;
            this.Id_Materia = Id_Materia;


        }
    }
}
