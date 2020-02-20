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
    public partial class UCClases : UserControl
    {
        CConexion Conexion;
        public string Usuario;
        List<CMaterias> Materias = new List<CMaterias>();
        List<CGrupos> Grupos = new List<CGrupos>();
        List<CAlumnos> Alunos = new List<CAlumnos>();
        int Id_Clase = 0;
        CClase Clase;
        public UCClases()
        {
            InitializeComponent();
        }

        private void btnIniciarClase_Click(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now + DateTime.Now.TimeOfDay;//ToString("yyyy-MM-dd")
            int IdMateia = Convert.ToInt16(CBMateria.SelectedValue);

            Clase = new CClase(txtTema.Text,ahora,1,IdMateia);
            Conexion.CrearClase(Clase);
            Clase.Id_Clase = Conexion.OptenerIdClase(IdMateia);
            foreach (var item in Alunos)
            {
                // aqui se crearra la asistencia de cada alumno
                CAsistencia Asistencia = new CAsistencia(item, Clase, 0, "");
                Conexion.CrearAsistencias(Asistencia);

            }
            //Conexion.OptenerAsistencias(Clase);
        }

        private void UCClases_Load(object sender, EventArgs e)
        {
            
            Conexion = CConexion.Instance;
            Conexion.Conectar();

            
        }

        private void CBGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void CBMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CBGrupo_Click(object sender, EventArgs e)
        {
            Conexion.OptenerGrupos(Grupos, Usuario);
            CBGrupo.DataSource = Grupos;
            CBGrupo.DisplayMember = "Nombre_Grupo";
            CBGrupo.ValueMember = "Id_Grupo";
           
            
            
        }

        private void CBMateria_Click(object sender, EventArgs e)
        {
            CBMateria.DataSource = null;
            Conexion.OptenerMaterias(Convert.ToInt16(CBGrupo.SelectedValue), Materias);
            CBMateria.DataSource = Materias;
            CBMateria.DisplayMember = "Nombre_Materia";
            CBMateria.ValueMember = "Id_Materia";
            Conexion.OptenerAlumnos(Alunos, Convert.ToInt16(CBGrupo.SelectedValue));

            dgvAlumnos.DataSource = Alunos;

        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {

        }
    }
}
