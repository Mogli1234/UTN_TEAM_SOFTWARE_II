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
using Project_View.Servicios;
using AccesoDatos.Modelo;


namespace Project_View
{
    public partial class Create_Sport : Form
    {
       Servicios.TEAM_SOFTWAREClient client = new Servicios.TEAM_SOFTWAREClient();
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
           
        }
    }
}
