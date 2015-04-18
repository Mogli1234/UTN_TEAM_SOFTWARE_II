using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_View.ServicioRutina;

namespace Project_View
{
    public partial class frm_VerRutinas : Form
    {
        private ServicioRutina.RutinasClient oRutinasClient;
        

        public frm_VerRutinas()
        {
            InitializeComponent();
            oRutinasClient =  new RutinasClient();
        }        

        private void frm_VerRutinas_Load(object sender, EventArgs e)
        {
            this.CargarRutinas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void CargarRutinas()
        {
            dtgRutinas.DataSource = oRutinasClient.ChargerRutinas();
            dtgRutinas.Columns[1].HeaderText = "Detalle Rutina";
            dtgRutinas.Columns[0].Visible = false;
        }
    }
}
