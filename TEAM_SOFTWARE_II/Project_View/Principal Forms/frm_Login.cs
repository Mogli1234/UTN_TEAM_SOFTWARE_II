using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_View.ServicioUsuario;

namespace Project_View
{
    public partial class frm_Login : Form
    {
        ServicioUsuario.UsuariosWebServiceClient client = new UsuariosWebServiceClient();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (client.VerifyUsers(txtUsername.Text,txtPassword.Text)==1)
            {
                
                MessageBox.Show("Bienvinido "+txtUsername.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Main_Menu main  = new Main_Menu(1);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bienvinido " + txtUsername.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Main_Menu main = new Main_Menu(0);
                main.Show();
                this.Hide();
                
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create_User create = new Create_User();
            create.Show();
            this.Hide();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
