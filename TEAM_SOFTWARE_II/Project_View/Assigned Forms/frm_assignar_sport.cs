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
using Project_View.ServicioRutina;

namespace Project_View
{
    public partial class frm_assignar_sport : Form
    {
        private ServicioDeporte.DeportesWebServiceClient oSportClient = new ServicioDeporte.DeportesWebServiceClient();
        private  ServicioRutina.RutinasClient oRutinasClient = new ServicioRutina.RutinasClient();
        rutinas_deportes rd = new rutinas_deportes();
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
            cmbSport.DisplayMember = "Deporte";
            cmbSport.ValueMember = "id";

            //Cargo las rutinas en este 
            cmbRutine.DataSource = oRutinasClient.ChargerRutinas();
            cmbRutine.DisplayMember = "Rutina";
            cmbSport.ValueMember = "id";
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            rd.rutina_id = (int?)cmbRutine.SelectedValue;
            rd.sport_id = (int?)cmbSport.SelectedValue;
            if (oRutinasClient.CreateRelation(rd))
            {
                MessageBox.Show("Se ha agregado correctamente", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
