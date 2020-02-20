using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CActividades
    {
        public int Id_Actividadad { get; set; }
        public int Id_Materia { get; set; }
        public int Valor { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public string Tipo { get; set; }
        public int Id_PE { get; set; }
        public int Unidad { get; set; }
        public string Nombre_Act { get; set; }

        public CActividades(int Id_Actividadad,int Id_Materia,int Valor,DateTime Fecha_Entrega, string Tipo,int Id_PE,int Unidad, string Nombre_Act)
        {
            this.Id_Actividadad = Id_Actividadad;
            this.Id_Materia = Id_Materia;
            this.Valor =Valor;
            this.Fecha_Entrega = Fecha_Entrega;
            this.Tipo = Tipo;
            this.Id_PE = Id_PE;
            this.Nombre_Act = Nombre_Act;
        }


    }
}
