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
    public partial class frm_assignar_sport : Form
    {
        private ServicioDeporte.DeportesWebServiceClient oSportClient = new ServicioDeporte.DeportesWebServiceClient();
        private  ServicioRutina.RutinasClient oRutinasClient = new RutinasClient();
        public frm_assignar_sport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_assignar_sport_Load(object sender, EventArgs e)
        {
            this.ChargeControls();
        }

        #region Cargar Controles
        void ChargeControls() 
        {
            //Cargo los deportes
            cmbSport.DataSource = oSportClient.ChargeSportsList();
            cmbSport.ValueMember = "id";
            cmbSport.DisplayMember = "Deporte";

            //Cargo las rutinas en este 
            cmbRutine.DataSource = oRutinasClient.ChargerRutinas();
            cmbRutine.DisplayMember = "Rutina";
            cmbSport.ValueMember = "id";
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            

        }
    }
}
