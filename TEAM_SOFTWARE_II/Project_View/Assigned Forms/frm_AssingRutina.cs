using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_View.ServicioDeporte;
using Project_View.ServicioParticipante;
using Project_View.ServicioRutina;


namespace Project_View
{
    public partial class frm_AssingRutina : Form
    {
        ServicioDeporte.DeportesWebServiceClient oSportClient = new DeportesWebServiceClient();
        ServicioRutina.RutinasClient oRutinasClient = new RutinasClient();
        ServicioParticipante.ParticipantesWebServiceClient oParticipanteClient = new ParticipantesWebServiceClient();
        public frm_AssingRutina()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AssingRutina_Load(object sender, EventArgs e)
        {
            this.charge_Objects();
        }


        #region Cargar Objeto
        public void charge_Objects() 
        {
            //Cargar Combox
            cmbSports.DataSource = oSportClient.ChargeSportsList();
            cmbSports.DisplayMember = "Deporte";
            cmbSports.ValueMember = "id";


            cmbRutina.DataSource = oRutinasClient.ChargerRutinas(); 
            cmbRutina.DisplayMember = "Rutina";
            cmbRutina.ValueMember = "Id";
            //carga Dartagrid
           

            //dtgParticipantes.Columns[0].Visible = false;
            //dtgParticipantes.Columns[1].HeaderText = "Nombre";
            //dtgParticipantes.Columns[2].HeaderText = "Primer Apellido";
            //dtgParticipantes.Columns[3].HeaderText = "Segundo Apellido";
            //dtgParticipantes.Columns[4].HeaderText = "Edad";
            //dtgParticipantes.Columns[5].HeaderText = "Fecha Ingreso";
        }
        #endregion

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
            dtgParticipantes.Columns[0].Visible = false;
            dtgParticipantes.Columns[1].HeaderText = "Nombre";
            dtgParticipantes.Columns[2].HeaderText = "Primer Apellido";
            dtgParticipantes.Columns[3].HeaderText = "Segundo Apellido";
            dtgParticipantes.Columns[4].HeaderText = "Edad";
            dtgParticipantes.Columns[5].HeaderText = "Fecha Ingreso";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
