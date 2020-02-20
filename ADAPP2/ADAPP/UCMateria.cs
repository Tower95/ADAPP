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
    public partial class UCMateria : UserControl
    {
        List<CMaterias> Materias = new List<CMaterias>();
        List<CPlanDeEstudio> PEs = new List<CPlanDeEstudio>();
        List<CActividades> Actividades = new List<CActividades>();
        CConexion Conexion;
        int Id_mat_select;
        int Id_Plan_Est;
        int Unidad;
        public string Usuario;
        public UCMateria()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion.OptenerMaterias(Usuario, Materias);
            listBMaterias.DataSource = Materias;
            listBMaterias.DisplayMember = "Nombre_Materia";
            lblUsuario.Text = Usuario;
        }

        private void listBMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBMaterias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PEs = new List<CPlanDeEstudio>();
          
            int index = this.listBMaterias.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                CMaterias materia = (CMaterias)listBMaterias.SelectedItem;
                Id_mat_select = (materia.Id_Materia);
                Conexion.OptenerPE(Id_mat_select, PEs);
                listBPlanEst.DataSource = PEs;
                listBPlanEst.DisplayMember = "Unidad";
                btnAgregarPE.Enabled = true;

            }
            
        }

        private void UCMateria_Load(object sender, EventArgs e)
        {
            Conexion = CConexion.Instance;
            Conexion.Conectar();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            Form_AgregarMateria ventana = new Form_AgregarMateria();
            ventana.Usuario = this.Usuario;
            ventana.Show();
        }

        private void btnAgregarPE_Click(object sender, EventArgs e)
        {
            Form_Agregar_PE ventana = new Form_Agregar_PE();
            ventana.Id_Materia = Id_mat_select;
            ventana.Show();
        }
        // metodo de seleccion de los planes de estudio
        private void listBPlanEst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Actividades = new List<CActividades>();
            int index = this.listBMaterias.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                CPlanDeEstudio PlanE = (CPlanDeEstudio)listBPlanEst.SelectedItem;
                Unidad = (PlanE.Unidad);
                Id_Plan_Est = PlanE.Id_PE;
                Conexion.OptenerActividades(Unidad, Id_Plan_Est, Actividades);
                dgvActividades.DataSource = null;
                dgvActividades.DataSource = Actividades;
                
                btnAgregarActividades.Enabled = true;


            }
        }

        private void listBPlanEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarActividades_Click(object sender, EventArgs e)
        {
            Form_Agregar_Actividad ventana = new Form_Agregar_Actividad();
            ventana.Unidad = this.Unidad;
            ventana.Id_Materia = this.Id_mat_select;
            ventana.ID_PE = Id_Plan_Est; 
            ventana.Show();
        }

        private void BtnRelacionar_Click(object sender, EventArgs e)
        {
            RelacionarGrMateria ventana = new RelacionarGrMateria();
            ventana.Usuario = Usuario;
            ventana.Show();
        }

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
