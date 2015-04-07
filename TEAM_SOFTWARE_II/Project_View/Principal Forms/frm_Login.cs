using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Modelo;
using Project_View.Servicio;

namespace Project_View
{
    public partial class frm_Login : Form
    {

        private user oUser;
        private TEAM_SOFTWAREClient oSoftwareClient;

        public frm_Login()
        {
            InitializeComponent();
            oUser = new user();
            oSoftwareClient= new TEAM_SOFTWAREClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUsername.Text == null) || (txtPassword.Text == null))
                {
                    MessageBox.Show("Error", "Debe digitar un nombre de usuario y una contraseña para iniciar secion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpiarCampos();
                }
                else
                {
                    oUser.Username = txtUsername.Text;
                    oUser.Password = txtPassword.Text;

                    MessageBox.Show("Bienvenido " + txtUsername.Text, "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpiarCampos();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCampos()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
