using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CAsistencia
    {
        public CAlumnos Alumno { get; set; }

        public CClase Clase { get; set; }

        public int valor { get; set; }

        public string Notas { get; set; }

        public CAsistencia(CAlumnos Alumno,CClase Clase,int valor,string Notas)
        {
            this.Alumno = Alumno;
            this.Clase = Clase;
            this.valor = valor;
            this.Notas = Notas;
        }


    }
}
