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
    public partial class RelacionarGrMateria : Form
    {
        public string Usuario;
        int Id_Grupo;
        int Id_materia;
        string Nombre_seleccion_Grupo;
        string Nombre_seleccion_Materia;
        CConexion Conexion;
        List<CGrupos> Grupos = new List<CGrupos>();
        List<CMaterias> Materias = new List<CMaterias>();
        List<CRelacionados> Relacionadas = new List<CRelacionados>();
        public RelacionarGrMateria()
        {
            InitializeComponent();
        }

        private void RelacionarGrMateria_Load(object sender, EventArgs e)
        {
            Conexion = CConexion.Instance;
            Conexion.Conectar();
            Conexion.OptenerGrupos(Grupos, Usuario);
            Conexion.OptenerMaterias(Usuario, Materias);
            LBGrupos.DataSource = Grupos;

            LBGrupos.DisplayMember = "Nombre_Grupo";
            CBSelectMateria.DataSource = Materias;
            CBSelectMateria.DisplayMember = "Nombre_Materia";
            CBSelectMateria.ValueMember = "Id_Materia";
            Conexion.OptenerRelacionGM(Relacionadas, Usuario);
            dgvRelaciones.DataSource = Relacionadas;

            
        }

        private void LBGrupos_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LBGrupos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.LBGrupos.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                CGrupos Grupo = (CGrupos)LBGrupos.SelectedItem;
                Id_Grupo = (Grupo.Id_Grupo);
                Nombre_seleccion_Grupo = Grupo.Nombre_Grupo;
                BtnRelacionar.Enabled = true;

            }
        }

        private void BtnRelacionar_Click(object sender, EventArgs e)
        {

            Conexion.CrearRelacion(Id_materia, Id_Grupo);
        }

        private void CBSelectMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
           Id_materia = Convert.ToInt16(((CMaterias)CBSelectMateria.SelectedItem).Id_Materia);
            Relacionadas = new List<CRelacionados>();
            dgvRelaciones.DataSource = null;
            Conexion.OptenerRelacionGM(Relacionadas, Usuario);
            dgvRelaciones.DataSource = Relacionadas;
            // Nombre_seleccion_Materia = Convert.ToString(CBSelectMateria.DisplayMember.);

        }
    }
}
