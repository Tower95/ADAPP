using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAPP
{
    public partial class UCAgregarAlumno : UserControl
    {
        public UCAgregarAlumno()
        {
            InitializeComponent();
        }

        private void UCAgregarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ocultar_Click(object sender, EventArgs e)
        {
            SendToBack();
            txtApellidos.Text = "";
            txtMatricula.Text="";
            txtNombre.Text="";
        }
    }
}
