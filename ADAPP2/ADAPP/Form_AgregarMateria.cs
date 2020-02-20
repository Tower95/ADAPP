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
    public partial class Form_AgregarMateria : Form
    {

        CConexion Conexion;
        List<CCiclo> ciclos = new List<CCiclo>();
        public string Usuario;
        public Form_AgregarMateria()
        {
            InitializeComponent();
        }

        private void Form_AgregarMateria_Load(object sender, EventArgs e)
        {

            Conexion = CConexion.Instance;
            Conexion.TraerCiclos(ciclos);

            cbCiclo.DataSource = ciclos;
            cbCiclo.ValueMember = "ID_Ciclo";
            cbCiclo.DisplayMember = "PeriodoCompleto";

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Conexion.AgregarMateria(txtNombreMateria.Text, Convert.ToInt16(txtHorasTotales.Text), Convert.ToInt16(cbCiclo.SelectedValue), Usuario);
        }
    }
}
