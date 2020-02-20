using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPP
{
    class CCiclo
    {
        public int ID_Ciclo { get; set; }
        public string Periodo { get; set; }
        public string Ano { get; set; }

        public string PeriodoCompleto { get; set; }
        public CCiclo(int ID_Ciclo,string Periodo,string Ano)
        {
            this.ID_Ciclo = ID_Ciclo;
            this.Periodo = Periodo;
            this.Ano = Ano;
            PeriodoCompleto = Ano +" "+ Periodo;
        }
    }
}
