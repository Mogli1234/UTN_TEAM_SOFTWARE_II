using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Entidades;
using Project_View.ServicioUsuario;

namespace Project_View.Principal_Forms
{
    public partial class Sed_Mail : Form
    {
        ServicioUsuario.UsuariosWebServiceClient client = new ServicioUsuario.UsuariosWebServiceClient();
        Email mail = new Email();
        public Sed_Mail()
        {
            InitializeComponent();
        }

        private void Sed_Mail_Load(object sender, EventArgs e)
        {
           this.chargerComponents();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (mail.email_send(txtFromMail.Text,cmbToEmail.SelectedItem.ToString(),txtSubjectMail.Text,txtBodyMail.Text))
            {
                MessageBox.Show("Se logro enviar correctamente el mensaje","SUCESS!!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Hubo un error a la hora de Enviar su correo", "FAILED!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region ChargerComponents
        private void chargerComponents()
        {
            cmbToEmail.DataSource = client.ChargeList();
            cmbToEmail.DisplayMember = "email";
            cmbToEmail.ValueMember = "id";
        }
        #endregion
    }
}
