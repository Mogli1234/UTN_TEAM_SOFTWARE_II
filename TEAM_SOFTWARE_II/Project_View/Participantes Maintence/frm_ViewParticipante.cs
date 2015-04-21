using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_View.ServicioParticipante;


namespace Project_View
{
    public partial class frm_ViewParticipante : Form
    {
        private ServicioParticipante.ParticipantesWebServiceClient oServiceClient;

        public frm_ViewParticipante()
        {
            InitializeComponent();
            oServiceClient = new ParticipantesWebServiceClient();
        }

        private void btnAceptarSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ViewParticipante_Load(object sender, EventArgs e)
        {
            dtg_Participantes.DataSource=oServiceClient.ListadoParticipantes();
            dtg_Participantes.Columns[0].Visible = false;
            dtg_Participantes.Columns[1].HeaderText = "Nombre";
            dtg_Participantes.Columns[2].HeaderText = "Primer Apellido";
            dtg_Participantes.Columns[3].HeaderText = "Segundo Apellido";
            dtg_Participantes.Columns[4].HeaderText = "Edad";
            dtg_Participantes.Columns[5].HeaderText = "Fecha de Ingreso";
        }


    }
}
