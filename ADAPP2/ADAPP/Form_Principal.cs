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
    public partial class Form_Principal : Form
    {
        public string Usuario;
        public Form_Principal()
        {
            InitializeComponent();
        }
        
        private void btn_materia_Click(object sender, EventArgs e)
        {
            ucMateria1.BringToFront();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Grupo_Click(object sender, EventArgs e)
        {
           ucGrupo1.BringToFront();
        }
        private void ucGrupo1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            this.ucMateria1.Usuario = this.Usuario;
            this.ucGrupo1.Usuario = Usuario;
            //lblUsuario.Text += Usuario;
        }

        private void ucClases1_Load(object sender, EventArgs e)
        {

        }

        private void btnClase_Click(object sender, EventArgs e)
        {
            ucClases1.Usuario = Usuario;
            ucClases1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ucGrupo1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
