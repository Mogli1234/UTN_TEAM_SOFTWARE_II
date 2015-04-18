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
    public partial class frm_EditarRutinas : Form
    {
        private ServicioRutina.RutinasClient oRutinasClient;
        private rutina oRutina;

        public frm_EditarRutinas()
        {
            InitializeComponent();
            oRutinasClient = new RutinasClient();
            oRutina = new rutina();
        }

        private void EditarRutinas_Load(object sender, EventArgs e)
        {
            this.CargarRutina();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        #region Evento Click en una celda del dtgEditRutinas
        private void dtgEditRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oRutina.id = Convert.ToInt32(dtgEditRutinas.Rows[e.RowIndex].Cells[0].Value);
            oRutina.Rutina1 = dtgEditRutinas.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        #endregion

        #region Accion de btnEliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (oRutinasClient.EliminarRutina((oRutina)))
            {
                MessageBox.Show("Se ha eliminado la rutina exitosamente", "SUCESS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar la rutina seleccionada", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            this.CargarRutina();
        }
        #endregion

        private void CargarRutina()
        {
            dtgEditRutinas.DataSource = oRutinasClient.ChargerRutinas();
            dtgEditRutinas.Columns[0].Visible = false;
            dtgEditRutinas.Columns[1].HeaderText = "Detalle de Rutina";
        }
    }
}