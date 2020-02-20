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
    public partial class Form_Agregar_PE : Form
    {
        public int Id_Materia;
        CConexion Conexion;
        public Form_Agregar_PE()
        {
            InitializeComponent();
        }

        private void Form_Agregar_PE_Load(object sender, EventArgs e)
        {
            Conexion = CConexion.Instance;
            Conexion.Conectar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Conexion.AgrgarPe(Convert.ToInt16(txtExamen.Text), Convert.ToInt16(txtTareas.Text), Convert.ToInt16(txtPracticas.Text), Convert.ToInt16(txtAsistencias.Text), Convert.ToUInt16(txtExtra.Text), Convert.ToUInt16(txtUnidades.Text), Id_Materia);
        }
    }
}
