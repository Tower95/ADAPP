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
    public partial class Login : Form
    {
        CConexion Conexion;
        public Login()
        {
            InitializeComponent();
            Conexion = CConexion.Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (Conexion.Ingreso(txtUsuaio.Text, txtPass.Text))
            {
                MessageBox.Show("Bienvenido " + txtUsuaio.Text);
                Form_Principal ventana = new Form_Principal();
                ventana.Usuario = txtUsuaio.Text;
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Incorrecto " + txtUsuaio.Text);
            }
            this.Hide();
           
           
        }
    }
}
