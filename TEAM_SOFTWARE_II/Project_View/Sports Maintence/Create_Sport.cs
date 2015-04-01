using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_View.Servicio;
using AccesoDatos.Modelo;


namespace Project_View
{
    public partial class Create_Sport : Form
    {
        Servicio.TEAM_SOFTWAREClient client = new Servicio.TEAM_SOFTWAREClient();
        deporte sport = new deporte();
        public Create_Sport()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            sport.Deporte1 = txtSport.Text;
            sport.Descripcion = txtDescription.Text;
            if (client.createSport(sport))
            {
                MessageBox.Show("Se ha agregado con exito el deporte","SUCESS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.limpiarCampos();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error a la hora de crear", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.limpiarCampos();    
            }
        }

        #region Metodo de limpiar campos
        void limpiarCampos()
        {
            txtSport.Clear();
            txtDescription.Clear();
            txtSport.Focus();
        }
        #endregion

    }
}
