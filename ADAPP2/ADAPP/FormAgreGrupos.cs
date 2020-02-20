using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAPP
{
    public partial class FormAgreGrupos : Form
    {
        List<CCiclo> Ciclos = new List<CCiclo>();
        CConexion Conexion;
        public FormAgreGrupos()
        {
            InitializeComponent();
        }

        private void FormAgreGrupos_Load(object sender, EventArgs e)
        {

            Conexion = CConexion.Instance;
            Conexion.Conectar();
            Conexion.TraerCiclos(Ciclos);

            cbCiclo.DataSource = Ciclos;
            cbCiclo.ValueMember = "ID_Ciclo";
            cbCiclo.DisplayMember = "PeriodoCompleto";
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Conexion.AgregarGrupo(txtNombreCiclo.Text, Convert.ToInt16(cbCiclo.SelectedValue));
        }
    }
}
