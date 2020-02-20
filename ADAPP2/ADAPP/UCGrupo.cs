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
    public partial class UCGrupo : UserControl
    {
        CConexion Conexion;
        List<CGrupos> Grupos = new List<CGrupos>();
        List<CMaterias> Materias = new List<CMaterias>();
        public string Usuario;
        public UCGrupo()
        {
            InitializeComponent();
        }

        private void UCGrupo_Load(object sender, EventArgs e)
        {
            Conexion = CConexion.Instance;
            Conexion.Conectar();
        }

        private void brn_agregarGrupo_Click(object sender, EventArgs e)
        {
            FormAgreGrupos ventana = new FormAgreGrupos();
            ventana.Show();
        }

        private void btn_AgrAlumno_Click(object sender, EventArgs e)
        {


        FormIngrersarAlumno ventana = new FormIngrersarAlumno();
            
        ventana.Show();
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion.OptenerGrupos(Grupos,Usuario);
            LBGrupos.DataSource = Grupos;
            LBGrupos.DisplayMember = "Nombre_Grupo";
        }

        private void LBGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
