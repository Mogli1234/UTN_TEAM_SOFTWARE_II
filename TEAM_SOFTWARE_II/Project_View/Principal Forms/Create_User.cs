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
using Project_View.ServicioUsuario;


namespace Project_View
{
    public partial class Create_User : Form
    {
      
        ServicioUsuario.UsuariosWebServiceClient client = new UsuariosWebServiceClient();
        user us = new user();
        
        public Create_User()
        {
            InitializeComponent();
            this.Limpiar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            log.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           frm_Login log = new frm_Login();
            if (txtPass.Text.Equals(txtConfirmPass.Text))
            {
                us.Username = txtUsername.Text;
                us.Email = txtEmail.Text;
                us.Password = txtPass.Text;
                if (client.NewUser(us))
                {
                    MessageBox.Show("Se ha creado con exito su usuario", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    log.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("A ocurrido un error a la hora de ingresar su usuario, tiene crendenciales incorrectas", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("La constraseñas no coinciden","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Limpiar();

        }

        public void Limpiar() 
        {
            txtPass.Clear();
            txtConfirmPass.Clear();
        }
    }
}
