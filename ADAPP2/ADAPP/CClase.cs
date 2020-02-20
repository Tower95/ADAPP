using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CClase
    {
        public int Id_Clase { get; set; }
        public string Tema { get; set; }
        public DateTime Fecha { get; set; }
        public int Duracion { get; set; }
        public int Id_Materia { get; set; }
        public  CClase(int Id_Clase, string Tema, DateTime Fecha, int Duracion, int Id_Materia)
        {
            this.Id_Clase = Id_Clase;
            this.Tema = Tema;
            this.Fecha = Fecha;
            this.Duracion = Duracion;
            this.Id_Materia = Id_Materia;

        }
        public CClase( string Tema, DateTime Fecha, int Duracion, int Id_Materia)
        {
            this.Id_Clase = 0;
            this.Tema = Tema;
            this.Fecha = Fecha;
            this.Duracion = Duracion;
            this.Id_Materia = Id_Materia;

        }
    }
}
