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
    public partial class FormIngrersarAlumno : Form
    {
        public string User;
        CConexion Conexion;
        List<CGrupos> Grupos = new List<CGrupos>();
        public FormIngrersarAlumno()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Conexion.IngesarAlumno( txtNombre.Text, txtMatricula.Text, txtApellidos.Text, Convert.ToInt16(CBGrupos.SelectedValue));
        }

        private void FormIngrersarAlumno_Load(object sender, EventArgs e)
        {
            Conexion = CConexion.Instance;
            Conexion.OptenerGrupos(Grupos, User);
            CBGrupos.DataSource = Grupos;
            CBGrupos.DisplayMember = "Nombre_Grupo";
            CBGrupos.ValueMember = "Id_Grupo";
        }
    }
}
