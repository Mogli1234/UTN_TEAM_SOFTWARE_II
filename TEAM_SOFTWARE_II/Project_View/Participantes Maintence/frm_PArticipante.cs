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
using Project_View.ServicioParticipante;

namespace Project_View
{
    public partial class frm_Participante : Form
    {
        private ParticipantesWebServiceClient oServiceClient;
        private participante oParticipante;

        public frm_Participante()
        {
            InitializeComponent();
            oServiceClient = new ParticipantesWebServiceClient();
            oParticipante = new participante();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Participante_Load(object sender, EventArgs e)
        {
            dt_fecha.Enabled = false;
            dt_fecha.Value = DateTime.Today;
        }

        private void btn_GuardarParticipante_Click(object sender, EventArgs e)
        {
            oParticipante.Nombre = txt_Nombre.Text;
            oParticipante.Primer_Apellido = txt_PrimerApellido.Text;
            oParticipante.Segundo_Apellido = txt_SegundoApellido.Text;
            oParticipante.Edad = Convert.ToInt32(intEdad.Value);
            oParticipante.Fecha_Ingreso = dt_fecha.Text;
            if (oServiceClient.InsertarParticipante(oParticipante))
            {
                MessageBox.Show("Se ingreso el participante correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Limpiar_cajas();
            }
            else
            {
                MessageBox.Show("Error al intentar ingresar datos de participante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Limpiar_cajas();
            }
        }

        #region Limpiador
        public void Limpiar_cajas()
        {
            txt_Nombre.Clear();
            intEdad.Value = 0;
            txt_PrimerApellido.Clear();
            txt_SegundoApellido.Clear();
            txt_Nombre.Focus();
        }
        #endregion
    }
}
