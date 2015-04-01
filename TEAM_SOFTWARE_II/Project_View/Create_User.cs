using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_View
{
    public partial class Create_User : Form
    {
      
        
        
        public Create_User()
        {
            InitializeComponent();
            this.Limpiar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            if (txtPass.Text.Equals(txtConfirmPass.Text))
            {
                
            }
            else
            {
                MessageBox.Show("La constraseñas no coinciden","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Limpiar();

        }

        public void Limpiar() 
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
            txtUsername.Focus();
        }
    }
}
