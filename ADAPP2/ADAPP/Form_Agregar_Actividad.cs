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
    public partial class Form_Agregar_Actividad : Form
    {
        public int Id_Materia;
        public int Unidad;
        public int ID_PE;
        CConexion Conexion;
        public Form_Agregar_Actividad()
        {
            InitializeComponent();
        }

        private void Form_Agregar_Actividad_Load(object sender, EventArgs e)
        {
            Conexion = CConexion.Instance;
            Conexion.Conectar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Conexion.AgregarActividad(Id_Materia, Convert.ToInt16(txtValor.Text), Calen.SelectionRange.Start, cbTipoDActv.SelectedItem.ToString(), ID_PE, Unidad, txtActividad.Text);
        }
    }
}
