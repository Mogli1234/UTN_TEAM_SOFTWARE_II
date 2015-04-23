using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AccesoDatos.Datos;
using Project_View.ServicioParticipante;
using AccesoDatos.Modelo;

namespace Project_View.Participantes_Maintence
{
    public partial class frm_EditarParticipante : Form
    {
        private ServicioParticipante.ParticipantesWebServiceClient oServiceClient;
        private participante oParticipante;
        private int edad;
        private DateTime fechaActual;
        public frm_EditarParticipante()
        {
            InitializeComponent();
            oServiceClient= new ParticipantesWebServiceClient();
            oParticipante= new participante();
            edad = 0;
            fechaActual = DateTime.Now;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oParticipante.Nombre=txtNombre.Text;
            oParticipante.Primer_Apellido = txtApellido1.Text;
            oParticipante.Segundo_Apellido = txtApellido2.Text;
            if (dtFechaNacimiento.Text!="")
            {
                oParticipante.Edad = Convert.ToInt32(fechaActual.Year) - Convert.ToInt32(dtFechaNacimiento.Value.Year);        
            }
 
            if (oServiceClient.EditarParticipante(oParticipante))
            {
                MessageBox.Show("Datos de participante actualizados correctamente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error, NO se pudo actualizar la informmacion del participante", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.LimpiarObjetosFormulario();
            this.CargarTablaParticipantes();
        }
        #region Eliminaccion de un participante
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (oServiceClient.EliminarParticipante(oParticipante))
            {
                MessageBox.Show("Participante eliminado exitosamente", "IMPORTANTE", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se ha podido eliminar el participante seleccionado", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            this.CargarTablaParticipantes();
            this.LimpiarObjetosFormulario();
        }
        #endregion

        #region Funciones basicas de limpieza y visual
        private void CargarTablaParticipantes()
        {
            dtgParticipantes.DataSource = oServiceClient.ListadoParticipantes();
            dtgParticipantes.Columns[0].Visible = false;
            dtgParticipantes.Columns[1].HeaderText = "Nombre";
            dtgParticipantes.Columns[2].HeaderText = "Primer Apellido";
            dtgParticipantes.Columns[3].HeaderText = "Segundo Apellido";
            dtgParticipantes.Columns[4].HeaderText = "Edad Cumplida";
            dtgParticipantes.Columns[5].HeaderText = "Fecha Ingreso";
            dtgParticipantes.Columns[5].ReadOnly= true;
            dtgParticipantes.Columns[6].Visible= false;
        }

        public void LimpiarObjetosFormulario()
        {
            txtNombre.Clear();
            txtNombre.Enabled = false;
            txtApellido1.Clear();
            txtApellido1.Enabled = false;
            txtApellido2.Clear();
            txtApellido2.Enabled = false;
            dtFechaNacimiento.Text= null;
            dtFechaNacimiento.Enabled = false;
        }
        #endregion

        #region Eventos Click y DobleClick en una celda del dtgEditRutinas
        private void dtgParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oParticipante.id = Convert.ToInt32(dtgParticipantes.Rows[e.RowIndex].Cells[0].Value);
            oParticipante.Nombre = dtgParticipantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            oParticipante.Primer_Apellido = dtgParticipantes.Rows[e.RowIndex].Cells[2].Value.ToString();
            oParticipante.Segundo_Apellido = dtgParticipantes.Rows[e.RowIndex].Cells[3].Value.ToString();
            oParticipante.Edad = Convert.ToInt32(dtgParticipantes.Rows[e.RowIndex].Cells[4].Value);
            oParticipante.Fecha_Ingreso = dtgParticipantes.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dtgParticipantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dtgParticipantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNombre.Enabled = true;
            txtApellido1.Text = dtgParticipantes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtApellido1.Enabled = true;
            txtApellido2.Text = dtgParticipantes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtApellido2.Enabled = true;
            dtFechaNacimiento.Enabled = true;
        }
        #endregion

        private void frm_EditarParticipante_Load(object sender, EventArgs e)
        {
            this.LimpiarObjetosFormulario();
            this.CargarTablaParticipantes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
