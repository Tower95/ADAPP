using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CAlumnos
    {
        public string Id_Alumnos { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Id_Grupo { get; set; }
        public int Activo { get; set; }
        public string NombreCompleto { get; set; }
        public CAlumnos(string Id_Alumnos, string Nombre, string Apellidos, int Id_Grupo, int Activo)
        {
            this.Id_Alumnos = Id_Alumnos;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Id_Grupo = Id_Grupo;
            this.Activo = Activo;

            NombreCompleto = Nombre + " " + Apellidos;
        }
    }
}
